using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Commons.Validations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.DataModel.Case;
using Anu.PunishmentOrg.DataModel.DiscoveryMinutes;
using Anu.PunishmentOrg.Enumerations;
using Anu.PunishmentOrg.ServiceModel.ServiceRequest;
using Anu.PunishmentOrg.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.PunishmentOrg.Service
{

    public class PDiscoveryMinutesController : Anu.PunishmentOrg.ServiceBase.PDiscoveryMinutesBase
    {
        public PDiscoveryMinutesController(Anu.DataAccess.IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override async Task<Result> PDiscovery(string No)
        {
            try
            {

                var pDiscovery = await _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(No);
                string title = pDiscovery.FirstOrDefault().TheObjectState.Title.ToString();

                //_unitOfWork.Complete();

                return AnuResult.Successful.GetResult();
            }
            catch (AnuExceptions ex)
            {
                return ex.result;
            }
        }

        /// <summary>
        /// وب سرویس استعلام وضعیت صورتجلسه کشف
        /// </summary>
        public override async Task<SendPDiscoveryMinutesStateResponse> SendPDiscoveryMinutesState([FromBody] SendPDiscoveryMinutesStateRequest request)
        {
            var sendPDiscoveryMinuteStateResponse = new SendPDiscoveryMinutesStateResponse();
            sendPDiscoveryMinuteStateResponse.UniqueNo = "-1";
            sendPDiscoveryMinuteStateResponse.UserName = request.Request.UserName;
            try
            {
                await Login.ValidateLoginAsync(request.Request, GFESUserAccessType.SendPDiscoveryMinute, _unitOfWork);

                request.UniqueNo.IsDigit(PDiscoveryMinutesResult.Error_UniqueNo_Is_Required);
                request.UniqueNo.NullOrWhiteSpace(PDiscoveryMinutesResult.Error_UniqueNo_Is_Required);

                var pDiscoveryMinutes = await _unitOfWork.PDiscoveryMinutes.GetPDiscoveryMinutesByUniqueNo(request.UniqueNo);
                pDiscoveryMinutes.Null(PDiscoveryMinutesResult.PDiscoveryMinuteSate_No_Is_NotValid);
                pDiscoveryMinutes.TheObjectState.Null(PDiscoveryMinutesResult.Error_to_Find_State);

                switch (pDiscoveryMinutes.TheObjectState.Code)
                {
                    case PunishmentOrgObjectState.PDiscoveryMinutes.PrimRegistery:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_PrimRegistery.GetResult();
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.SendToSmuggling:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_SendToSmuggling.GetResult();
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.ConfirmAndSendToUnit:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.UnitNo = pDiscoveryMinutes.TheReceiverUnit.Code;
                        sendPDiscoveryMinuteStateResponse.UnitName = pDiscoveryMinutes.TheReceiverUnit.UnitName;
                        sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_ConfirmAndSendToUnit.GetResult();
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.ReferToUnit:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.UnitNo = pDiscoveryMinutes.TheReferUnit.Code;
                        sendPDiscoveryMinuteStateResponse.UnitName = pDiscoveryMinutes.TheReferUnit.UnitName;
                        sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_ReferToUnit.GetResult();
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.ReferToCity:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.UnitNo = pDiscoveryMinutes.TheCityPuoRefUnit.Code;
                        sendPDiscoveryMinuteStateResponse.UnitName = pDiscoveryMinutes.TheCityPuoRefUnit.UnitName;
                        sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_ReferToCity.GetResult();
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.CreateCaseInUnit:
                        sendPDiscoveryMinuteStateResponse = await this.CaseStateOfPDiscoveryMinute(sendPDiscoveryMinuteStateResponse, pDiscoveryMinutes);
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.Start:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_Start.GetResult();
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.Expire:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_Expired.GetResult();
                        //اگر گزارش بازرسی ابطال شده باشد دلیل ابطال را پر میکنیم
                        //این فیلد فعلا دیده نشده است 
                        //ToDo
                        return sendPDiscoveryMinuteStateResponse;
                    default:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.Error_to_Find_State.GetResult();
                        return sendPDiscoveryMinuteStateResponse;
                }
            }
            catch (AnuExceptions ex)
            {
                return new SendPDiscoveryMinutesStateResponse { Result = ex.result };
            }
            catch(Exception ex)
            {
                return new SendPDiscoveryMinutesStateResponse { Result = AnuResult.Error.GetResult(ex) };
            }

        }

        private async Task<SendPDiscoveryMinutesStateResponse> CaseStateOfPDiscoveryMinute(SendPDiscoveryMinutesStateResponse sendPDiscoveryMinutesStateResponse, PDiscoveryMinutes pDiscoveryMinutes)
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


            var pCaseCollection = await _unitOfWork.PCaseRepository.GetPCaseByNo(pDiscoveryMinutes.ThePCase.No);

            #region وقت رسیدگی

            var thePRegistaryTimeCaseCollection = await _unitOfWork.PRegistaryTimeCase.GetPRegistaryTimeCaseByNo(
                pDiscoveryMinutes.ThePCase.No, PURegisterTimeType.Disposition);


            if (thePRegistaryTimeCaseCollection.Count() != 0)
            {
                var registerTimeCase = thePRegistaryTimeCaseCollection.ToList()[0];

                sendPDiscoveryMinutesStateResponse.RegisterDate = registerTimeCase?.ThePRegistaryTime?.RegisterDate;
            }

            #endregion وقت رسیدگی

            #region اجرای احکام
            bool RevisionHas = false;
            foreach (PCase item in pCaseCollection)
            {
                if (Revision.Contains(item.TheHandlerUnit.TheGUnitType.Code))
                {
                    RevisionHas = true;
                }
            }

            foreach (PCase item in pCaseCollection)
            {
                if (Executive.Contains(item.TheHandlerUnit.TheGUnitType.Code))
                {
                    sendPDiscoveryMinutesStateResponse.Result = PDiscoveryMinutesResult.Execution.GetResult();
                    if (item.CaseArchiveState == PUCaseArchiveState.Closed)
                        sendPDiscoveryMinutesStateResponse.Result.Description = "حکم صادر شده اجرا شده است.";
                    if (item.CaseArchiveState == PUCaseArchiveState.Active)
                        sendPDiscoveryMinutesStateResponse.Result.Description = "حکم صادر شده در حال اجرا است.";
                    if (RevisionHas)
                        sendPDiscoveryMinutesStateResponse.RevisionRequest = "دارای تجدید نظر میباشد.";
                    sendPDiscoveryMinutesStateResponse.UniqueNo = pDiscoveryMinutes.UniqueNo;
                    sendPDiscoveryMinutesStateResponse.UnitName = pDiscoveryMinutes.ThePCase.TheHandlerUnit.UnitName;
                    sendPDiscoveryMinutesStateResponse.UnitNo = pDiscoveryMinutes.ThePCase.TheHandlerUnit.Code;
                    return sendPDiscoveryMinutesStateResponse;
                }
            }
            #endregion اجرای احکام

            #region بررسی اینکه رای صادر شده یا نه
            var thePJudgmentCase = await _unitOfWork.PJudgmentCase.GetPJudgmentCaseByObjectID(pDiscoveryMinutes.ThePCase.SourceObjectId);

            if (thePJudgmentCase.Count() != 0)
            {
                sendPDiscoveryMinutesStateResponse.Result = PDiscoveryMinutesResult.PJudgment.GetResult();

                #region Fiil_Judgment_Information
                var pJudgmentCase = thePJudgmentCase.ToList()[0];

                sendPDiscoveryMinutesStateResponse.Result.Description = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(pJudgmentCase.ThePJudgment.VerdictText));
                sendPDiscoveryMinutesStateResponse.Result.Message = sendPDiscoveryMinutesStateResponse.Result.Message + "*" + pJudgmentCase.ThePJudgment.No;
                #endregion Fiil_Judgment_Information

                if (RevisionHas)
                    sendPDiscoveryMinutesStateResponse.RevisionRequest = "دارای تجدید نظر میباشد.";
                sendPDiscoveryMinutesStateResponse.UnitNo = pDiscoveryMinutes.TheReferUnit.Code;
                sendPDiscoveryMinutesStateResponse.UnitName = pDiscoveryMinutes.TheReferUnit.UnitName;
                return sendPDiscoveryMinutesStateResponse;
            }
            #endregion بررسی اینکه رای صادر شده یا نه

            #region تشکیل پرونده و شروع به رسیدگی
            else
            {
                sendPDiscoveryMinutesStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_CreateCase.GetResult();
                return sendPDiscoveryMinutesStateResponse;
            }
            #endregion تشکیل پرونده و شروع به رسیدگی
            return null;
        }

    }
}
