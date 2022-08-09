using Anu.Commons.Validations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.DataAccess;
using Anu.PunishmentOrg.ServiceBase;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.ServiceModel.ServiceRequest;
using Anu.PunishmentOrg.ServiceModel.ServiceResponse;
using Microsoft.AspNetCore.Mvc;
using Utility.Exceptions;
using Utility.Guard;
using static Anu.Constants.ServiceModel.PunishmentOrg.PunishmentOrgObjectState;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Utility;
using Anu.PunishmentOrg.Enumerations;
using Anu.PunishmentOrg.Domain.InspectionReport;
using Anu.PunishmentOrg.Domain.Case;
using Anu.PunishmentOrg.Domain.Terminate;
using Anu.PunishmentOrg.DataAccess.InspectionReport;
using Anu.PunishmentOrg.DataAccess.PCase;
using Anu.PunishmentOrg.DataAccess.Terminate;

namespace Anu.PunishmentOrg.Service
{
    public class PInspectionReportController : PInspectionReportBase
    {
        public PInspectionReportController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override async Task<SendPInspectionReportStateResponse> SendPInspectionReportState([FromBody] SendPInspectionReportStateRequest request)
        {
            try
            {
                await LoginValidation.ValidateLoginAsync(request.Request, Anu.Constants.ServiceModel.PunishmentOrg.PunishmentOrgConstants.GFESUserAccessType.SendPInspectionReportServices, _unitOfWork);

                request.UniqueNo.NullOrWhiteSpace(PInspectionReportResult.Error_UniqueNo_Is_Required, "مکانیزه گزارش بازرسی");
                request.UniqueNo.IsDigit(PInspectionReportResult.Error_UniqueNo_Is_Required, args: "مکانیزه گزارش بازرسی");
                
                var thePInspectionReport = await _unitOfWork.Repositorey<PInspectionReportRepository>().GetPInspectionReportByUniqueNo(request.UniqueNo);
                thePInspectionReport.Null(PInspectionReportResult.PInspectionReport_No_Is_NotValid);
                thePInspectionReport.TheObjectState.Null(PInspectionReportResult.Error_to_Find_State, "گزارش بازرسی");


                var sendPInspectionReportStateResponse = new SendPInspectionReportStateResponse();
                sendPInspectionReportStateResponse.UniqueNo = "-1";
                sendPInspectionReportStateResponse.UserName = request.UserName;

                switch (thePInspectionReport.TheObjectState.Code)
                {
                    case PInspectionReport.Drafted_old:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Drafted_Old.GetResult();
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.Refered_old:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Refered_old.GetResult();
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.Drafted:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Drafted.GetResult();
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.ReturndToRegistrar:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Return_to_Registrar.GetResult();
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.RegisteredToManagerConfirm:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Registered_to_ManagerConfirm.GetResult();
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.ReceivedFromSupportOrg:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Received_From_SupportOrg.GetResult();
                        sendPInspectionReportStateResponse.UniqueNo = thePInspectionReport.No;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.Expired:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Expired.GetResult();
                        //اگر گزارش بازرسی ابطال شده باشد دلیل ابطال را پر میکنیم
                        //این فیلد فعلا دیده نشده است 
                        //ToDo
                        sendPInspectionReportStateResponse.Result.Description = "";
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.ReturndToReferrer:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Returnd_to_Referrer.GetResult();
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.Referred:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Referred.GetResult();
                        sendPInspectionReportStateResponse.UnitNo = thePInspectionReport.TheReferUnit.Code;
                        sendPInspectionReportStateResponse.UnitName = thePInspectionReport.TheReferUnit.UnitName;
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.ReferredToCity:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Referred_To_City.GetResult();
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.RegisterCase:
                        sendPInspectionReportStateResponse = await this.CaseStateOfPInspection(sendPInspectionReportStateResponse, thePInspectionReport);
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    case PInspectionReport.ReturndToSender:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Returnd_To_Sender.GetResult();
                        //اگر گزارش بازرسی به سازمان ارسال کننده برگشت شده باشد دلیل بازگشت را پر میکنیم
                        //این فیلد فعلا دیده نشده است 
                        //ToDo
                        sendPInspectionReportStateResponse.Result.Description = "";
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                    default:
                        sendPInspectionReportStateResponse.Result = PInspectionReportResult.Error_to_Find_State.GetResult("گزارش بازرسی");
                        sendPInspectionReportStateResponse.UniqueNo = request.UniqueNo;
                        return sendPInspectionReportStateResponse;
                }
            }
            catch (AnuExceptions ex)
            {
                return new SendPInspectionReportStateResponse() { Result=ex.result };
            }
            catch(Exception ex)
            {
                return new SendPInspectionReportStateResponse() { Result = AnuResult.Error.GetResult(ex) }; 
            }
        }


        private async Task<SendPInspectionReportStateResponse> CaseStateOfPInspection(SendPInspectionReportStateResponse sendPInspectionReportStateResponse, DataModel.InspectionReport.PInspectionReport thePInspectionReport)
        {
            List<string> Executive = new List<string>();
            Executive.Add("008");
            Executive.Add("011");
            Executive.Add("012");

            List<string> Revision = new List<string>();
            Revision.Add("006");
            Revision.Add("007");
            Revision.Add("014");
            Revision.Add("015");

            var pCaseCollection = await _unitOfWork.Repositorey<PCaseRepository>().GetPCaseByNo(thePInspectionReport.ThePCase.No);

            #region وقت رسیدگی

            var thePRegistaryTimeCaseCollection = await _unitOfWork.Repositorey<IPRegistaryTimeCaseRepository> ().GetPRegistaryTimeCaseByNo(thePInspectionReport.ThePCase.No, PURegisterTimeType.Disposition);

            if (thePRegistaryTimeCaseCollection.Count() != 0)
            {
                var registerDateTimeItem = thePRegistaryTimeCaseCollection.ToList()[0];

                sendPInspectionReportStateResponse.RegisterDate = registerDateTimeItem?.ThePRegistaryTime?.RegisterDate;
            }

            #endregion وقت رسیدگی

            #region اجرای احکام
            bool RevisionHas = false;
            foreach (var item in pCaseCollection)
            {
                if (Revision.Contains(item.TheHandlerUnit.TheGUnitType.Code))
                {
                    RevisionHas = true;
                }
            }

            foreach (var item in pCaseCollection)
            {
                if (Executive.Contains(item.TheHandlerUnit.TheGUnitType.Code))
                {
                    sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_Execution.GetResult();
                    if (item.CaseArchiveState == PUCaseArchiveState.Closed)
                        sendPInspectionReportStateResponse.Result.Description = "حکم صادر شده اجرا شده است.";
                    if (item.CaseArchiveState == PUCaseArchiveState.Active)
                        sendPInspectionReportStateResponse.Result.Description = "حکم صادر شده در حال اجرا است.";
                    if (RevisionHas)
                        sendPInspectionReportStateResponse.RevisionRequest = "دارای تجدید نظر میباشد.";
                    sendPInspectionReportStateResponse.UniqueNo = thePInspectionReport.No;
                    sendPInspectionReportStateResponse.UnitName = thePInspectionReport.ThePCase.TheHandlerUnit.UnitName;
                    sendPInspectionReportStateResponse.UnitNo = thePInspectionReport.ThePCase.TheHandlerUnit.Code;
                    return sendPInspectionReportStateResponse;
                }
            }
            #endregion اجرای احکام

            #region بررسی اینکه رای صادر شده یا نه
            var thePJudgmentCase = await _unitOfWork.Repositorey<PJudgmentCaseRepository>().GetPJudgmentCaseByObjectID(thePInspectionReport.ThePCase.SourceObjectId);
            if (thePJudgmentCase.Count() != 0)
            {
                sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_PJudgment.GetResult();

                #region Fiil_Judgment_Information
                var pJudgmentCase = thePJudgmentCase.ToList()[0];

                sendPInspectionReportStateResponse.Result.Description = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(pJudgmentCase.ThePJudgment.VerdictText));
                sendPInspectionReportStateResponse.Result.Message = sendPInspectionReportStateResponse.Result.Message + "*" + pJudgmentCase.ThePJudgment.No;
                #endregion Fiil_Judgment_Information

                if (RevisionHas)
                    sendPInspectionReportStateResponse.RevisionRequest = "دارای تجدید نظر میباشد.";
                sendPInspectionReportStateResponse.UnitNo = thePInspectionReport.TheReferUnit.Code;
                sendPInspectionReportStateResponse.UnitName = thePInspectionReport.TheReferUnit.UnitName;
                return sendPInspectionReportStateResponse;
            }
            #endregion بررسی اینکه رای صادر شده یا نه

            #region تشکیل پرونده و شروع به رسیدگی
            else
            {
                sendPInspectionReportStateResponse.Result = PInspectionReportResult.PInspectionReport_RegisterCase.GetResult();
                return sendPInspectionReportStateResponse;
            }
            #endregion تشکیل پرونده و شروع به رسیدگی

        }

    }
}
