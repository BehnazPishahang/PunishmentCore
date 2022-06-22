using DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes;
using Microsoft.AspNetCore.Mvc;
using PunishmentOrg.Domain.Interface;
using ServiceModel.Commons.ServiceResponse;
using ServiceModel.Constants;
using ServiceRequest.Anu.PunishmentOrg;
using ServiceResponse.Anu.PunishmentOrg;
using Utility;
using Utility.Exceptions;
using Utility.Guard;
using Validations.Commons;

namespace PunishmentOrg.Api.Core.Service.Anu.PunishmentOrg
{

    public class PDiscoveryMinutesController : ServiceBase.Anu.PunishmentOrg.IPDiscoveryMinutesBase
    {
        public PDiscoveryMinutesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //[HttpGet(Name = "PDiscoveryMinutes/{UniqueNo}")]
        //public async Task<string> PDiscoveryMinutesAsync(string UniqueNo)
        //{
        //    await Task.Delay(1);
        //    //var pDiscovery = await _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(UniqueNo);
        //    //string title = pDiscovery.FirstOrDefault().TheObjectState.Title.ToString();

        //    var byParentCode = _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(UniqueNo);
        //    var byNO = _unitOfWork.PCaseRepository.GetTerminateCaseByNo("");

        //    _unitOfWork.Complete();


        //    return "";
        //}

        public override async Task<Result> PDiscovery(string No)
        {
            try
            {
                No = null;
                No.Null(ResultType.Error);


                var pDiscovery = await _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(No);
                string title = pDiscovery.FirstOrDefault().TheObjectState.Title.ToString();

                _unitOfWork.Complete();


                return new Result { Code = ResultType.Successful.ToString(), Message = title };
            }
            catch (AnuExceptions ex)
            {
                return ex.result;
            }
        }

        public override async Task<SendPDiscoveryMinutesStateResponse> SendPDiscoveryMinutesState([FromBody] SendPDiscoveryMinutesStateRequest request)
        {
            var sendPDiscoveryMinuteStateResponse = new SendPDiscoveryMinutesStateResponse();
            sendPDiscoveryMinuteStateResponse.UniqueNo = "-1";
            sendPDiscoveryMinuteStateResponse.UserName = request.Request.UserName;
            try
            {
                await Login.ValidateLoginAsync(request.Request, ServiceModel.Constants.GFESUserAccessType.SendPDiscoveryMinute, _unitOfWork);

                request.UnitNo.IsDigit(ResultType.Error_UniqueNo_Is_Required);
                request.UnitNo.NullOrWhiteSpace(ResultType.Error_UniqueNo_Is_Required);

                var pDiscoveryMinutes = await _unitOfWork.PDiscoveryMinutes.GetPDiscoveryMinutesByUniqueNo(request.UniqueNo);
                pDiscoveryMinutes.Null(ResultType.PDiscoveryMinuteSate_No_Is_NotValid);
                pDiscoveryMinutes.TheObjectState.Null(ResultType.Error_to_Find_State);

                switch (pDiscoveryMinutes.TheObjectState.Code)
                {
                    case PunishmentOrgObjectState.PDiscoveryMinutes.PrimRegistery:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = ResultUtility.getResult(ResultType.PDiscoveryMinuteSate_PrimRegistery);
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.SendToSmuggling:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = ResultUtility.getResult(ResultType.PDiscoveryMinuteSate_SendToSmuggling);
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.ConfirmAndSendToUnit:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.UnitNo = pDiscoveryMinutes.TheReceiverUnit.Code;
                        sendPDiscoveryMinuteStateResponse.UnitName = pDiscoveryMinutes.TheReceiverUnit.UnitName;
                        sendPDiscoveryMinuteStateResponse.Result = ResultUtility.getResult(ResultType.PDiscoveryMinuteSate_ConfirmAndSendToUnit);
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.ReferToUnit:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.UnitNo = pDiscoveryMinutes.TheReferUnit.Code;
                        sendPDiscoveryMinuteStateResponse.UnitName = pDiscoveryMinutes.TheReferUnit.UnitName;
                        sendPDiscoveryMinuteStateResponse.Result = ResultUtility.getResult(ResultType.PDiscoveryMinuteSate_ReferToUnit);
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.ReferToCity:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.UnitNo = pDiscoveryMinutes.TheCityPuoRefUnit.Code;
                        sendPDiscoveryMinuteStateResponse.UnitName = pDiscoveryMinutes.TheCityPuoRefUnit.UnitName;
                        sendPDiscoveryMinuteStateResponse.Result = ResultUtility.getResult(ResultType.PDiscoveryMinuteSate_ReferToCity);
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.CreateCaseInUnit:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.Start:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = ResultUtility.getResult(ResultType.PDiscoveryMinuteSate_Start);
                        return sendPDiscoveryMinuteStateResponse;
                    case PunishmentOrgObjectState.PDiscoveryMinutes.Expire:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = ResultUtility.getResult(ResultType.PDiscoveryMinuteSate_Expired);
                        //اگر گزارش بازرسی ابطال شده باشد دلیل ابطال را پر میکنیم
                        //این فیلد فعلا دیده نشده است 
                        //ToDo
                        return sendPDiscoveryMinuteStateResponse;
                    default:
                        sendPDiscoveryMinuteStateResponse.UniqueNo = request.UnitNo;
                        sendPDiscoveryMinuteStateResponse.Result = ResultUtility.getResult(ResultType.Error_to_Find_State);
                        return sendPDiscoveryMinuteStateResponse;
                }



                return null;
            }
            catch (AnuExceptions ex)
            {
                return new SendPDiscoveryMinutesStateResponse { Result = ex.result };
            }
            catch(Exception ex)
            {
                return new SendPDiscoveryMinutesStateResponse { Result = ResultUtility.getResult(ResultType.Error,ex) };
            }

        }

        private SendPDiscoveryMinutesStateResponse CaseStateOfPDiscoveryMinute(SendPDiscoveryMinutesStateResponse sendPDiscoveryMinutesStateResponse, PDiscoveryMinutes pDiscoveryMinutes)
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


            //var pCaseCollection = _unitOfWork.PCaseRepository.GetPCaseByNo(pDiscoveryMinutes.ThePCase.No);

            //#region وقت رسیدگی
            //Criteria criteriaRegisterTime = new Criteria();
            //criteriaRegisterTime.AddEqualTo(Anu.PunishmentOrgQueryBase.PRegistaryTimeCase.ThePCase.No, thePDiscoveryMinutes.ThePCase.No);
            //criteriaRegisterTime.AddGreaterOrEqualThan(Anu.PunishmentOrgQueryBase.PRegistaryTimeCase.ThePRegistaryTime.RegisterDate, Anu.BaseInfoContext.Instance.CurrentDate);
            //criteriaRegisterTime.AddEqualTo(Anu.PunishmentOrgQueryBase.PRegistaryTimeCase.ThePRegistaryTime.TimeType, DataModel.Anu.Enumerations.PunishmentOrg.PURegisterTimeType.Disposition);
            //IPRegistaryTimeCaseCollection thePRegistaryTimeCaseCollection = (IPRegistaryTimeCaseCollection)Anu.InstanceBuilder.GetEntityListByCriteria<IPRegistaryTimeCase>(criteriaRegisterTime);

            //thePRegistaryTimeCaseCollection.Sort(true, new string[] { "ThePRegistaryTime.RegisterDate" });

            //if (thePRegistaryTimeCaseCollection.Count != 0)
            //{
            //    IPRegistaryTimeCase registerDateTimeItem = (IPRegistaryTimeCase)thePRegistaryTimeCaseCollection.GetItem(0);

            //    sendPDiscoveryMinutesStateResponse.RegisterDate = registerDateTimeItem?.ThePRegistaryTime?.RegisterDate;
            //}

            //#endregion وقت رسیدگی

            //#region اجرای احکام
            //bool RevisionHas = false;
            //foreach (IPCase item in pCaseCollection)
            //{
            //    if (Revision.Contains(item.TheHandlerUnit.TheGUnitType.Code))
            //    {
            //        RevisionHas = true;
            //    }
            //}

            //foreach (IPCase item in pCaseCollection)
            //{
            //    if (Executive.Contains(item.TheHandlerUnit.TheGUnitType.Code))
            //    {
            //        sendPDiscoveryMinutesStateResponse = this.ReturnResultSendPDiscoveryMinuteStateResponse(sendPDiscoveryMinutesStateResponse, Anu.Constants.PunishmentOrg.ResultCode.SendPDiscoveryMinuteStateResultServiceResult_Successful_PDiscoveryMinuteSate_Execution);
            //        if (item.CaseArchiveState == Enumerations.PunishmentOrg.PUCaseArchiveState.Closed)
            //            sendPDiscoveryMinutesStateResponse.Result.Description = "حکم صادر شده اجرا شده است.";
            //        if (item.CaseArchiveState == Enumerations.PunishmentOrg.PUCaseArchiveState.Active)
            //            sendPDiscoveryMinutesStateResponse.Result.Description = "حکم صادر شده در حال اجرا است.";
            //        if (RevisionHas)
            //            sendPDiscoveryMinutesStateResponse.RevisionRequest = "دارای تجدید نظر میباشد.";
            //        sendPDiscoveryMinutesStateResponse.UniqueNo = thePDiscoveryMinutes.UniqueNo;
            //        sendPDiscoveryMinutesStateResponse.UnitName = thePDiscoveryMinutes.ThePCase.TheHandlerUnit.UnitName;
            //        sendPDiscoveryMinutesStateResponse.UnitNo = thePDiscoveryMinutes.ThePCase.TheHandlerUnit.Code;
            //        return sendPDiscoveryMinutesStateResponse;
            //    }
            //}
            //#endregion اجرای احکام

            //#region بررسی اینکه رای صادر شده یا نه
            //criteria = new Criteria();
            //criteria.AddEqualTo(Anu.PunishmentOrgQueryBase.PJudgmentCase.ThePCase.ObjectId, thePDiscoveryMinutes.ThePCase.ObjectId);
            //IPJudgmentCaseCollection thePJudgmentCase = (IPJudgmentCaseCollection)Anu.InstanceBuilder.GetEntityListByCriteria<IPJudgmentCase>(criteria);
            //if (thePJudgmentCase.Count != 0)
            //{
            //    sendPDiscoveryMinutesStateResponse = this.ReturnResultSendPDiscoveryMinuteStateResponse(sendPDiscoveryMinutesStateResponse, Anu.Constants.PunishmentOrg.ResultCode.SendPDiscoveryMinuteStateResultServiceResult_Successful_PDiscoveryMinuteSate_PJudgment);

            //    #region Fiil_Judgment_Information
            //    thePJudgmentCase.Sort(false, new string[] { "ThePJudgment.JudgeDateTime" });
            //    IPJudgmentCase pJudgmentCase = (IPJudgmentCase)thePJudgmentCase.GetItem(0);
            //    sendPDiscoveryMinutesStateResponse.Result.Description = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(pJudgmentCase.ThePJudgment.VerdictText));
            //    sendPDiscoveryMinutesStateResponse.Result.Message = sendPDiscoveryMinutesStateResponse.Result.Message + "*" + pJudgmentCase.ThePJudgment.No;
            //    #endregion Fiil_Judgment_Information

            //    if (RevisionHas)
            //        sendPDiscoveryMinutesStateResponse.RevisionRequest = "دارای تجدید نظر میباشد.";
            //    sendPDiscoveryMinutesStateResponse.UnitNo = thePDiscoveryMinutes.TheReferUnit.Code;
            //    sendPDiscoveryMinutesStateResponse.UnitName = thePDiscoveryMinutes.TheReferUnit.UnitName;
            //    return sendPDiscoveryMinutesStateResponse;
            //}
            //#endregion بررسی اینکه رای صادر شده یا نه

            //#region تشکیل پرونده و شروع به رسیدگی
            //else
            //{
            //    return this.ReturnResultSendPDiscoveryMinuteStateResponse(sendPDiscoveryMinutesStateResponse, Anu.Constants.PunishmentOrg.ResultCode.SendPDiscoveryMinuteStateResultServiceResult_Successful_PDiscoveryMinuteSate_CreateCase);
            //}
//#endregion تشکیل پرونده و شروع به رسیدگی
            return null;
        }

    }
}
