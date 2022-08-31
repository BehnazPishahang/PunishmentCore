using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.Api.Authentication;
using Anu.PunishmentOrg.DataModel.Case;
using Anu.PunishmentOrg.DataModel.DiscoveryMinutes;
using Anu.PunishmentOrg.Domain.Case;
using Anu.PunishmentOrg.Domain.DiscoveryMinutes;
using Anu.PunishmentOrg.Domain.Terminate;
using Anu.PunishmentOrg.Enumerations;
using Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.DiscoveryMinutes
{
    public class PDiscoveryMinutesServiceController : PDiscoveryMinutesServiceControllerBase
    {
        #region Constructor
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;


        public PDiscoveryMinutesServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        [PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.SendPDiscoveryMinute)]
        public override async Task<PDiscoveryMinutesStateResponse> SendPDiscoveryMinutesState([FromBody] PDiscoveryMinutesStateRequest request)
        {
            request.ThePDiscoveryMinutesInputContract.UniqueNo.NullOrWhiteSpace(PDiscoveryMinutesResult.Error_UniqueNo_Is_Required, "یکتای صورتجلسه کشف");
            request.ThePDiscoveryMinutesInputContract.UniqueNo.IsDigit(PDiscoveryMinutesResult.Error_UniqueNo_Is_Required, args: "یکتای صورتجلسه کشف");

            var pDiscoveryMinutes = await _unitOfWork.Repositorey<IPDiscoveryMinutesRepository>().GetPDiscoveryMinutesByUniqueNo(request.ThePDiscoveryMinutesInputContract.UniqueNo);
            pDiscoveryMinutes.Null(PDiscoveryMinutesResult.PDiscoveryMinuteSate_No_Is_NotValid);
            pDiscoveryMinutes.TheObjectState.Null(PDiscoveryMinutesResult.Error_to_Find_State, "صورتجلسه کشف");

            var sendPDiscoveryMinuteStateResponse = new PDiscoveryMinutesStateResponse();
            sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = "-1";

            switch (pDiscoveryMinutes.TheObjectState.Code)
            {
                case PunishmentOrgObjectState.PDiscoveryMinutes.PrimRegistery:
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_PrimRegistery.GetResult();
                    return sendPDiscoveryMinuteStateResponse;
                case PunishmentOrgObjectState.PDiscoveryMinutes.SendToSmuggling:
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_SendToSmuggling.GetResult();
                    return sendPDiscoveryMinuteStateResponse;
                case PunishmentOrgObjectState.PDiscoveryMinutes.ConfirmAndSendToUnit:
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UnitNo = pDiscoveryMinutes.TheReceiverUnit.Code;
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UnitName = pDiscoveryMinutes.TheReceiverUnit.UnitName;
                    sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_ConfirmAndSendToUnit.GetResult();
                    return sendPDiscoveryMinuteStateResponse;
                case PunishmentOrgObjectState.PDiscoveryMinutes.ReferToUnit:
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UnitNo = pDiscoveryMinutes.TheReferUnit.Code;
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UnitName = pDiscoveryMinutes.TheReferUnit.UnitName;
                    sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_ReferToUnit.GetResult();
                    return sendPDiscoveryMinuteStateResponse;
                case PunishmentOrgObjectState.PDiscoveryMinutes.ReferToCity:
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UnitNo = pDiscoveryMinutes.TheCityPuoRefUnit.Code;
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UnitName = pDiscoveryMinutes.TheCityPuoRefUnit.UnitName;
                    sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_ReferToCity.GetResult();
                    return sendPDiscoveryMinuteStateResponse;
                case PunishmentOrgObjectState.PDiscoveryMinutes.CreateCaseInUnit:
                    sendPDiscoveryMinuteStateResponse = await this.CaseStateOfPDiscoveryMinute(sendPDiscoveryMinuteStateResponse, pDiscoveryMinutes);
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    return sendPDiscoveryMinuteStateResponse;
                case PunishmentOrgObjectState.PDiscoveryMinutes.Start:
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_Start.GetResult();
                    return sendPDiscoveryMinuteStateResponse;
                case PunishmentOrgObjectState.PDiscoveryMinutes.Expire:
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.PDiscoveryMinuteSate_Expired.GetResult();
                    //اگر گزارش بازرسی ابطال شده باشد دلیل ابطال را پر میکنیم
                    //این فیلد فعلا دیده نشده است 
                    //ToDo
                    return sendPDiscoveryMinuteStateResponse;
                default:
                    sendPDiscoveryMinuteStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = request.ThePDiscoveryMinutesInputContract.UniqueNo;
                    sendPDiscoveryMinuteStateResponse.Result = PDiscoveryMinutesResult.Error_to_Find_State.GetResult("صورتجلسه کشف");
                    return sendPDiscoveryMinuteStateResponse;
            }


        }

        private async Task<PDiscoveryMinutesStateResponse> CaseStateOfPDiscoveryMinute(PDiscoveryMinutesStateResponse sendPDiscoveryMinutesStateResponse, PDiscoveryMinutes pDiscoveryMinutes)
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


            var pCaseCollection = await _unitOfWork.Repositorey<IPCaseRepository>().GetPCaseByNo(pDiscoveryMinutes.ThePCase.No);

            #region وقت رسیدگی

            var thePRegistaryTimeCaseCollection = await _unitOfWork.Repositorey<IPRegistaryTimeCaseRepository>().GetPRegistaryTimeCaseByNo(
                pDiscoveryMinutes.ThePCase.No, PURegisterTimeType.Disposition);


            if (thePRegistaryTimeCaseCollection.Count() != 0)
            {
                var registerTimeCase = thePRegistaryTimeCaseCollection.ToList()[0];

                sendPDiscoveryMinutesStateResponse.ThePDiscoveryMinutesStateContract.RegisterDate = registerTimeCase?.ThePRegistaryTime?.RegisterDate;
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
                        sendPDiscoveryMinutesStateResponse.ThePDiscoveryMinutesStateContract.RevisionRequest = "دارای تجدید نظر میباشد.";
                    sendPDiscoveryMinutesStateResponse.ThePDiscoveryMinutesStateContract.UniqueNo = pDiscoveryMinutes.UniqueNo;
                    sendPDiscoveryMinutesStateResponse.ThePDiscoveryMinutesStateContract.UnitName = pDiscoveryMinutes.ThePCase.TheHandlerUnit.UnitName;
                    sendPDiscoveryMinutesStateResponse.ThePDiscoveryMinutesStateContract.UnitNo = pDiscoveryMinutes.ThePCase.TheHandlerUnit.Code;
                    return sendPDiscoveryMinutesStateResponse;
                }
            }
            #endregion اجرای احکام

            #region بررسی اینکه رای صادر شده یا نه
            var thePJudgmentCase = await _unitOfWork.Repositorey<IPJudgmentCaseRepository>().GetPJudgmentCaseByObjectID(pDiscoveryMinutes.ThePCase.SourceObjectId);

            if (thePJudgmentCase.Count() != 0)
            {
                sendPDiscoveryMinutesStateResponse.Result = PDiscoveryMinutesResult.PJudgment.GetResult();

                #region Fiil_Judgment_Information
                var pJudgmentCase = thePJudgmentCase.ToList()[0];

                sendPDiscoveryMinutesStateResponse.Result.Description = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(pJudgmentCase.ThePJudgment.VerdictText));
                sendPDiscoveryMinutesStateResponse.Result.Message = sendPDiscoveryMinutesStateResponse.Result.Message + "*" + pJudgmentCase.ThePJudgment.No;
                #endregion Fiil_Judgment_Information

                if (RevisionHas)
                    sendPDiscoveryMinutesStateResponse.ThePDiscoveryMinutesStateContract.RevisionRequest = "دارای تجدید نظر میباشد.";
                sendPDiscoveryMinutesStateResponse.ThePDiscoveryMinutesStateContract.UnitNo = pDiscoveryMinutes.TheReferUnit.Code;
                sendPDiscoveryMinutesStateResponse.ThePDiscoveryMinutesStateContract.UnitName = pDiscoveryMinutes.TheReferUnit.UnitName;
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

        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides
        #endregion Overrides

        #region Methods
        #endregion Methods
    }
}