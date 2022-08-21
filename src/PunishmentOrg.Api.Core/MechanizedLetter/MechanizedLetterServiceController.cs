
using Anu.BaseInfo.DataModel.MechanizedLetter;
using Anu.BaseInfo.ServiceModel.MechanizedLetter;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utility;
using Utility.CalendarHelper;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.BaseInfo.Api.MechanizedLetter
{
    public class MechanizedLetterServiceController : MechanizedLetterServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;
        #region Constructor
        public MechanizedLetterServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides

        public async override Task<MechanizedLetterResponse> SendMechanizedLetter([FromBody] MechanizedLetterRequest request)
        { 
            return null;
        }
        //{
        //    var OneMechanizedLetterResponse = new MechanizedLetterResponse();
        //    var GMechanizedLetterType = await _unitOfWork.GMechanizedLetterType.GetByCode(request.TheGMechanizedLetterContract.TheGMechanizedLetterTypeContract.Code);
        //    var NajaUnit = await _unitOfWork.NAJAUnit.GetByCode(request.TheGMechanizedLetterContract.TheNAJAUnitContract.Code);
        //    try
        //    {
        //        // await LoginValidation.ValidateLoginAsync(request.Request, PunishmentOrgConstants.GFESUserAccessType.SendPBillStoreService, _unitOfWork);


        //        #region Validation

        //        #region [CreatorUserName]
        //        if (request.TheGMechanizedLetterContract.CreatorUserName == null || request.TheGMechanizedLetterContract.CreatorUserName == String.Empty)
        //        {
        //            return Respond(MechanizedLetterResult.MechanizedLetter_CreatorUserName_Is_Null);

        //        }
        //        #endregion [CreatorUserName]

        //        #region [OuterOrgLetterDate]

        //        request.TheGMechanizedLetterContract.OuterOrgLetterDate.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_OuterOrgLetterDate_Is_Null);
        //        request.TheGMechanizedLetterContract.OuterOrgLetterDate.IsValidDate(MechanizedLetterResult.MechanizedLetter_OuterOrgLetterDate_Is_Not_ValidDate);

        //        #endregion [OuterOrgLetterDate]


        //        #region [OuterOrgLetterNo]
        //        request.TheGMechanizedLetterContract.OuterOrgLetterNo.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_OuterOrgLetterNo_Is_Null, args: "شماره نامه فرستنده را وارد نمایید.");
        //        request.TheGMechanizedLetterContract.OuterOrgLetterNo.IsDigit(MechanizedLetterResult.MechanizedLetter_OuterOrgLetterNo_Is_Not_Digit, args: "شماره نامه فرستنده از نوع عدد نمی باشد.");

        //        #endregion [OuterOrgLetterNo]


        //        #region [GMechanizedLetterType]
        //        List<string> GMechanizedLetterTypeCodes = new List<string>();
        //        GMechanizedLetterTypeCodes.Add("00027");
        //        GMechanizedLetterTypeCodes.Add("00028");
        //        GMechanizedLetterTypeCodes.Add("00029");
        //        GMechanizedLetterTypeCodes.Add("00030");


        //        if (request.TheGMechanizedLetterContract.TheGMechanizedLetterTypeContract.Code == null || !GMechanizedLetterTypeCodes.Contains(request.TheGMechanizedLetterContract.TheGMechanizedLetterTypeContract.Code))
        //        {
        //            return Respond(MechanizedLetterResult.MechanizedLetter_GMechanizedLetterTypeCode_Is_Not_Valid);

        //        }
        //        #endregion [GMechanizedLetterType]

        //        #region [TheGMechanizedLetterReceiverList]
        //        if (request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList == null ||
        //            (request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList != null && request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList.Count == 0))
        //        {
        //            return Respond(MechanizedLetterResult.MechanizedLetter_RecieveGMechanizedLetterServiceResult_Reciver_Is_Null);
        //        }
        //        #endregion [TheGMechanizedLetterReceiverList]

        //        #region [TheSenderOuterOrg]

        //        request.TheGMechanizedLetterContract.TheNAJAUnitContract.Code.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_SenderOuterOrgCode_Is_Null);


        //        if (NajaUnit == null)
        //        {
        //            return Respond(MechanizedLetterResult.MechanizedLetter_SenderOuterOrgCode_Is_Not_Valid);
        //        }

        //        #endregion [TheSenderOuterOrg]

        //        #region [TheReceiverInnerOrg]
        //        foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList)
        //        {
        //            if (item.TheCMSOrganizationContract.Code != null)
        //            {
        //                var OneCMSOrganization = await _unitOfWork.CMSOrganization.GetByCode(item.TheCMSOrganizationContract.Code);

        //                if (OneCMSOrganization == null)
        //                {
        //                    return Respond(MechanizedLetterResult.MechanizedLetter_TheReceiverInnerOrgCode_Is_Not_Valid);

        //                }
        //            }
        //        }
        //        #endregion [TheReceiverInnerOrg]

        //        #region LetterText
        //        if (request.TheGMechanizedLetterContract.LetterText == null || request.TheGMechanizedLetterContract.LetterText == string.Empty)
        //        {
        //            return Respond(MechanizedLetterResult.MechanizedLetter_LetterText_Is_Null);

        //        }
        //        #endregion

        //        #endregion

        //        #region CreateGMechanizedLetter
        //        GMechanizedLetter OneGMechanizedLetter = new()
        //        {
        //            Id = Guid.NewGuid().ToString("N"),
        //            Timestamp = 1,
        //            CreateDateTime = CalendarHelper.GetCurrentDateTime(),
        //            OuterOrgLetterNo = (request.TheGMechanizedLetterContract.OuterOrgLetterNo is null) ? null : request.TheGMechanizedLetterContract.OuterOrgLetterNo,
        //            OuterOrgLetterDate = (request.TheGMechanizedLetterContract.OuterOrgLetterDate is null) ? null : request.TheGMechanizedLetterContract.OuterOrgLetterDate,
        //            LetterText = request.TheGMechanizedLetterContract.LetterText,
        //            IsSendByOuterOrg = Enumerations.YesNo.Yes,
        //            CreatorUserName = request.TheGMechanizedLetterContract.CreatorUserName,
        //            TheObjectState = _unitOfWork.ObjectState.GetById(PunishmentOrgObjectState.PMechanizeLetter.ConfirmedToSend),
        //        };

        //        #region GMechanizedLetterType 

        //        OneGMechanizedLetter.TheGMechanizedLetterType = (GMechanizedLetterType is null) ? null : GMechanizedLetterType;
        //        #endregion

        //        #region NajaUnit

        //        OneGMechanizedLetter.TheSenderOuterOrg = (NajaUnit is null) ? null : NajaUnit;
        //        #endregion

        //        #region GMechanizedLetterReceiver

        //        foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList)
        //        {
        //            var ReceiverInnerOrg = await _unitOfWork.CMSOrganization.GetByCode(item.TheCMSOrganizationContract.Code);
        //            var CMSUserRoleType = await _unitOfWork.CMSUserRoleType.GetByCode(item.TheCMSUserRoleTypeContract.Code);
        //            var MaxNo = await _unitOfWork.GMechanizedLetter.GetMaxNo(CalendarHelper.GetCurrentDate().Substring(0, 4), item.TheCMSOrganizationContract.Code);
        //            OneGMechanizedLetter.TheGMechanizedLetterReceiverList = new();
        //            var oneGMechanizedLetterReceiver = new GMechanizedLetterReceiver()
        //            {
        //                Id = Guid.NewGuid().ToString("N"),
        //                IsMechanizeRelation = Enumerations.YesNo.Yes,
        //                InnerOrOutterRcvType = Enumerations.MechanizedLetterReceiverType.InnerOrg,
        //                MainRcvOrTranscriptRcv = item.MainRcvOrTranscriptRcv,
        //                ReceiverType = item.ReceiverType,
        //                SendDateTime = CalendarHelper.GetCurrentDateTime(),
        //                ViewDateTime = "9999/99/99-99:99",
        //                TheObjectState = _unitOfWork.ObjectState.GetById(PunishmentOrgObjectState.PMechanizeLetter.ReceivedByReceiverUnit),
        //                TheReceiverInnerOrg = (ReceiverInnerOrg is null) ? null : ReceiverInnerOrg,
        //                TheReceiverPost = (CMSUserRoleType is null) ? null : CMSUserRoleType

        //            };
        //            OneGMechanizedLetter.TheGMechanizedLetterReceiverList.Add(oneGMechanizedLetterReceiver);

        //            if (request.TheGMechanizedLetterContract.No == null)
        //            {

        //                OneGMechanizedLetter.No = MaxNo;

        //            }


        //            #region DefineWorkItemsForMechanizeLetter
        //            //string relatedCMSUserId = null;
        //            //string relatedCMSOrgId = null;
        //            //string OneNAJAUnit = null;
        //            //string relatedCMSUserRoleTypeId = null;
        //            //string vGUID = Guid.NewGuid().ToString().Replace("-", string.Empty);

        //            ////todo
        //            ////if (item.TheReceiverUserAndPost != null)
        //            ////    relatedCMSUserId = item.TheReceiverUserAndPost.TheCmsUserContract.id;

        //            //#region Inner
        //            //if (item.InnerOrOutterRcvType == Enumerations.MechanizedLetterReceiverType.InnerOrg)
        //            //{
        //            //    #region CMSOrganization
        //            //    var OneCMSOrganization = await _unitOfWork.CMSOrganization.GetByCode(item.TheCMSOrganizationContract.Code);
        //            //    relatedCMSOrgId = OneCMSOrganization.Id;
        //            //    #endregion

        //            //    #region CMSUserRoleType

        //            //    if (item.TheCMSUserRoleTypeContract.Code != null)
        //            //    {
        //            //        var OnerelatedCMSUserRoleType = await _unitOfWork.CMSUserRoleType.GetByCode(item.TheCMSUserRoleTypeContract.Code);
        //            //        relatedCMSUserRoleTypeId = OnerelatedCMSUserRoleType.Id;
        //            //    }

        //            //    #endregion

        //            //    #region CMSUser
        //            //    //todo
        //            //    //if (item.TheReceiverUserAndPost != null)
        //            //    //{
        //            //    //    var OnerelatedCMSUserRoleType = await _unitOfWork.CMSUserRoleType.GetByCode(item.TheCMSUserRoleTypeContract.Code);
        //            //    //    relatedCMSUserRoleTypeId = OnerelatedCMSUserRoleType.Id;
        //            //    //}
        //            //    //relatedCMSUserId = item.TheReceiverUserAndPost.TheCmsUserContract.ObjectId;

        //            //    #endregion

        //            //    #region واحد
        //            //    if (item.ReceiverType == Enumerations.MechanizeRefererType.Unit)
        //            //    {
        //            //        if (item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "005" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "006" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "007" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "013" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "014" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "015")
        //            //            relatedCMSUserRoleTypeId = "0012";

        //            //        else if (item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "003" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "004" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "009" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "016")
        //            //            relatedCMSUserRoleTypeId = "0010";

        //            //        else if (item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "008" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "010" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "011" ||
        //            //            item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "012")
        //            //            relatedCMSUserRoleTypeId = "0042";

        //            //        else if (item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "001")
        //            //            relatedCMSUserRoleTypeId = "0005";

        //            //        else if (item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "017")
        //            //            relatedCMSUserRoleTypeId = "0008";

        //            //        else if (item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "018")
        //            //            relatedCMSUserRoleTypeId = "0009";

        //            //        else if (item.TheCMSOrganizationContract.TheunitContract.GUnitTypeId == "019")
        //            //            relatedCMSUserRoleTypeId = "0013";

        //            //        DefineWorkItemsForMechanizeLetter("000236"//vCMSOrgMechanized.GetMechanizedDefaultBaseRole().Id
        //            //           , OneGMechanizedLetter
        //            //           , relatedCMSUserId
        //            //           , relatedCMSOrgId
        //            //           , "9003239250EA48C3A583FA2DAC0D0E2C"//systemform
        //            //           , relatedCMSUserRoleTypeId, true, vGUID, "8fc11d43c5a24efa8e209b3cc05ca450", oneGMechanizedLetterReceiver.Id);
        //            //    }
        //            //    #endregion

        //            //    #region سمت
        //            //    else if (item.ReceiverType == Enumerations.MechanizeRefererType.PostRole)
        //            //    {
        //            //        DefineWorkItemsForMechanizeLetter("000236"//vCMSOrgMechanized.GetMechanizedDefaultBaseRole().Id
        //            //            , OneGMechanizedLetter
        //            //            , relatedCMSUserId
        //            //            , relatedCMSOrgId
        //            //            , "9003239250EA48C3A583FA2DAC0D0E2C"//systemform
        //            //            , relatedCMSUserRoleTypeId, true, vGUID, "8fc11d43c5a24efa8e209b3cc05ca450", oneGMechanizedLetterReceiver.Id);
        //            //    }

        //            //    #endregion

        //            //    #region کاربر
        //            //    else if (item.ReceiverType == Enumerations.MechanizeRefererType.UserPost)
        //            //    {
        //            //        //relatedCMSUserId = item.TheReceiverUserAndPost.TheCmsUserContract.ObjectId;

        //            //        //DefineWorkItemsForMechanizeLetter("000236"//vCMSOrgMechanized.GetMechanizedDefaultBaseRole().Id
        //            //        //    , OneGMechanizedLetter
        //            //        //    , relatedCMSUserId
        //            //        //    , relatedCMSOrgId
        //            //        //    , "9003239250EA48C3A583FA2DAC0D0E2C"//systemform
        //            //        //    , relatedCMSUserRoleTypeId, true, vGUID, "8fc11d43c5a24efa8e209b3cc05ca450", oneGMechanizedLetterReceiver.Id);
        //            //    }
        //            //    #endregion
        //            //}
        //            //#endregion


        //            #endregion

        //        }

        //        #endregion

        //        #region Case
        //        foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterCaseContractList)
        //        {
        //            OneGMechanizedLetter.TheGMechanizedLetterCaseList = new();
        //            var Unit = await _unitOfWork.Unit.GetByCode(item.TheunitContract.Code);
        //            var CaseList = await _unitOfWork.PCase.GetPCaseByNo(item.RelatedCaseNo);
        //            var OneCaseId = "";
        //            foreach (var caseItem in CaseList)
        //            {
        //                if (caseItem.TheHandlerUnit.Id == Unit.Id)
        //                {
        //                    OneCaseId = caseItem.Id;

        //                }
        //            }
        //            var GMechanizedLetterCase = new GMechanizedLetterCase()
        //            {
        //                Id = Guid.NewGuid().ToString("N"),
        //                TheUnit = (Unit is null) ? null : Unit,
        //                RelatedCaseNo = item.RelatedCaseNo,
        //                RelatedCaseTitle = item.RelatedCaseTitle,
        //                CaseLocation = Enumerations.MechanizedLetterCaseLocation.Destination,
        //                TheRelatedCaseClass = _unitOfWork.SystemObject.GetById("21c7d5f0a1524460898a56c0417e0755"),
        //                TheRelatedCaseForm = _unitOfWork.SystemForm.GetById("5A1F4099A1B6437BA5E1D568000A751C"),
        //                RelatedCaseID = OneCaseId,

        //            };
        //            OneGMechanizedLetter.TheGMechanizedLetterCaseList.Add(GMechanizedLetterCase);
        //        }
        //        #endregion

        //        #region RelLetters
        //        foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterRelLettersContractList)
        //        {
        //            OneGMechanizedLetter.TheRelLettersList = new();
        //            var GMechanizedLetterObj = await _unitOfWork.GMechanizedLetter.GetByNo(item.RelLetterNo);
        //            var oneGMechanizedLetterRelLetters = new GMechanizedLetterRelLetters()
        //            {
        //                Id = Guid.NewGuid().ToString("N"),
        //                RelationType = item.RelationType,
        //                RelLetterDate = item.RelLetterDate,
        //                RelLetterGetType = item.RelLetterGetType,
        //                RelLetterNo = item.RelLetterNo,
        //                TheMainLetter = OneGMechanizedLetter,
        //                TheRelLetter = (GMechanizedLetterObj is null) ? null : GMechanizedLetterObj,

        //            };

        //            OneGMechanizedLetter.TheRelLettersList.Add(oneGMechanizedLetterRelLetters);
        //        }
        //        #endregion

        //        #region GMechanizedLetterFieldsContractList
        //        int turn = 1;

        //        switch (GMechanizedLetterType.Code)
        //        {

        //            // معرفی نماینده حقوقی جهت شرکت در جلسه رسیدگی
        //            case "00027":

        //                break;

        //            //درخواست تجدید نظر از سمت سازمان حمایت
        //            case "00028":
        //                break;

        //            //پاسخ درخواست کارشناسی در خصوص پرونده
        //            case "00029":
        //                break;
        //            //سایر موضوعات مکاتبه در خصوص پرونده
        //            case "00030":
        //                break;

        //        }

        //        foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterFieldsContractList)
        //        {
        //        }

        //        #endregion


        //        _unitOfWork.GMechanizedLetter.Add(OneGMechanizedLetter);
        //        _unitOfWork.Complete();
        //        return Respond(AnuResult.Successful, OneGMechanizedLetter.No);

        //        //OneMechanizedLetterResponse.Result.Description = OneGMechanizedLetter.No;
        //        //OneMechanizedLetterResponse.Result.Code = 1000;
        //        //OneMechanizedLetterResponse.Result.Message = "عملیات با موفقیت انجام شد .";
        //        #endregion

        //        return OneMechanizedLetterResponse;


        //    }
        //    catch (AnuExceptions ex)
        //    {
        //        OneMechanizedLetterResponse.Result = ex.result;
        //        return OneMechanizedLetterResponse;
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        return new MechanizedLetterResponse() { Result = AnuResult.Error.GetResult(ex) };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new MechanizedLetterResponse() { Result = AnuResult.Error.GetResult(ex) };
        //    }


        //}
        #endregion Overrides

        #region Methods
        private MechanizedLetterResponse Respond(AnuResult result, string? no)
        {

            var response = new MechanizedLetterResponse()
            {
                Result = result.GetResult(),
                TheGMechanizedLetterOutputContract = new GMechanizedLetterOutputContract() { No = no}
            };
            return response;



        }
        private MechanizedLetterResponse Respond(MechanizedLetterResult result)
        {
            var response = new MechanizedLetterResponse() { Result = result.GetResult() };
            return response;
        }

        //public async void DefineWorkItemsForMechanizeLetter(string baseRoleId
        //   , Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter MechanizedLetterObject
        //   , string RelatedCMSUserId = null
        //   , string RelatedOrganizationId = null
        //   , string SystemFormId = null
        //   , string RelatedCMSUserRoleTypeId = null
        //   , bool SameCaseServerForSenderAndReceiver = true
        //   , string WorkFlowInstanceWorkItemId = null
        //   , string RelatedDocObjectId = null
        //   , string RelatedDocId = null)
        //{

        //    string CaseId = null;
        //    string CaseNo = null;
        //    string CaseSystemObjectId = null;

        //    if (MechanizedLetterObject.TheGMechanizedLetterCaseList.Count > 0)
        //    {
        //        CaseNo = MechanizedLetterObject.TheGMechanizedLetterCaseList[0].RelatedCaseNo;
        //        if (CaseNo.Length > 19)
        //            CaseNo = CaseNo.Substring(0, 19);

        //        CaseId = MechanizedLetterObject.TheGMechanizedLetterCaseList[0].RelatedCaseID;

        //        CaseSystemObjectId = "b40dcb897f584550a24460272ced792f";//systemObject

        //    }

        //    var baseRole = _unitOfWork.BaseRole.GetById(baseRoleId);

        //    if (string.IsNullOrEmpty(RelatedOrganizationId))
        //    {
        //        //todo
        //        RelatedOrganizationId = "Anu.BaseInfoContext.Instance.CurrentCMSOrganization.ObjectId";

        //    }

        //    string TempNo = "";
        //    Insert(
        //    CalendarHelper.GetCurrentDate(),
        //    baseRole.Id,
        //    baseRole.Name,
        //    "9999/99/99",
        //    RelatedOrganizationId,
        //    baseRole.Name,
        //    CaseId,
        //    CaseNo,
        //    CaseSystemObjectId,
        //    RelatedDocObjectId,
        //    RelatedDocId,
        //    MechanizedLetterObject.No,
        //    SystemFormId,
        //    Enumerations.WorkFlowActivityInstanceState.Processing,
        //    Enumerations.WorkFlowWorkItemType.NonWorkFlow,
        //    Enumerations.YesNo.Yes,
        //    TempNo,
        //    "",
        //    RelatedCMSUserId,
        //    RelatedCMSUserRoleTypeId,
        //    SameCaseServerForSenderAndReceiver,
        //    WorkFlowInstanceWorkItemId);

        //    //IGMechanizedLetterReceiver ReferObject = (IGMechanizedLetterReceiver)MechanizedLetterObject.TheGMechanizedLetterReceiverList[MechanizedLetterObject.TheGMechanizedLetterReceiverList.Count - 1];

        //    //if (!SameCaseServerForSenderAndReceiver)
        //    //{
        //    //    Anu.DBLoging.IDataNotSend newDataNotSend = Anu.InstanceBuilder.NewEntity<Anu.DBLoging.IDataNotSend>();
        //    //    newDataNotSend.TransactionOrderNo = GetNewTransactionSequence();

        //    //    newDataNotSend.TheSenderCMSOrganization = MechanizedLetterObject.TheSenderInnerOrg;
        //    //    newDataNotSend.TheReceiverServer = ReferObject.TheReceiverInnerOrg.TheCaseServer;
        //    //    newDataNotSend.ReceiverServerType = Anu.Enumerations.ReceiverServerType.CMSServer;
        //    //    newDataNotSend.ChangeDateTime = Anu.BaseInfoContext.Instance.CurrentDateTime;
        //    //    newDataNotSend.CommandType = Anu.Enumerations.CommandType.Insert;
        //    //    newDataNotSend.DataObjectId = newWorkItemObject.ObjectId;
        //    //    newDataNotSend.TheSystemObject = newWorkItemObject.GetSystemObject();
        //    //}
        //}

        //public async void Insert(string activateDate, string baseRoleId, string description, string maxDelayDate, string securityOrganizationId, string title,
        //                   string relatedCaseId, string relatedCaseNo, string relatedSystemObjectCaseId,
        //                   string relatedDocObjectId, string relatedDocId, string relatedDocNo, string RelatedDocFormId,
        //                   Enumerations.WorkFlowActivityInstanceState state, Enumerations.WorkFlowWorkItemType type, Enumerations.YesNo userCanDelay,
        //                   string temp1, string temp2, string relatedCMSUserId = null, string RelatedCMSUserRoleTypeId = null, bool SameCaseServerForSenderAndReceiver = true, string ObjectId = null)
        //{
        //    WorkFlowInstanceWorkItem workFlowInstanceWorkItem = null;
        //    //todo
        //    //if (!string.IsNullOrEmpty(ObjectId))
        //    //{
        //    //    workFlowInstanceWorkItem = Anu.InstanceBuilder.NewEntity<IWorkFlowInstanceWorkItem>(ObjectId);
        //    //}
        //    //else
        //    //{
        //    //    workFlowInstanceWorkItem = Anu.InstanceBuilder.NewEntity<IWorkFlowInstanceWorkItem>();
        //    //}

        //    workFlowInstanceWorkItem.MaxDelayDate = maxDelayDate;
        //    workFlowInstanceWorkItem.CreateDateTime = CalendarHelper.GetCurrentDateTime();
        //    workFlowInstanceWorkItem.ActivateDate = activateDate;

        //    //todo
        //    //if (SameCaseServerForSenderAndReceiver == true)
        //    //workFlowInstanceWorkItem.TheCreatorUser = Anu.BaseInfoContext.Instance.CurrentUser;

        //    workFlowInstanceWorkItem.Title = title;
        //    workFlowInstanceWorkItem.TheBaseRole = _unitOfWork.BaseRole.GetById(baseRoleId);
        //    workFlowInstanceWorkItem.KeyField1 = temp1;
        //    workFlowInstanceWorkItem.KeyField2 = temp2;

        //    if (string.IsNullOrEmpty(description))
        //        workFlowInstanceWorkItem.Description = workFlowInstanceWorkItem.TheBaseRole.Name;
        //    else
        //        workFlowInstanceWorkItem.Description = description;

        //    workFlowInstanceWorkItem.State = state;
        //    workFlowInstanceWorkItem.Type = type;
        //    workFlowInstanceWorkItem.UserCanDelay = userCanDelay;
        //    workFlowInstanceWorkItem.TheRelatedSystemObjectCase = _unitOfWork.SystemObject.GetById(relatedSystemObjectCaseId);
        //    workFlowInstanceWorkItem.SecurityOrganizationId = securityOrganizationId;
        //    workFlowInstanceWorkItem.RelatedCaseNo = relatedCaseNo;
        //    workFlowInstanceWorkItem.RelatedCaseId = relatedCaseId;
        //    workFlowInstanceWorkItem.TheRelatedDocObject = _unitOfWork.SystemObject.GetById(relatedDocObjectId);
        //    workFlowInstanceWorkItem.RelatedDocId = relatedDocId;
        //    workFlowInstanceWorkItem.RelatedDocNo = relatedDocNo;
        //    workFlowInstanceWorkItem.TheRelatedDocForm = _unitOfWork.SystemForm.GetById(RelatedDocFormId);
        //    workFlowInstanceWorkItem.TheRelatedCMSUser = _unitOfWork.CMSUser.GetById(relatedCMSUserId);
        //    workFlowInstanceWorkItem.TheRelatedCMSUserRoleType = _unitOfWork.CMSUserRoleType.GetById(RelatedCMSUserRoleTypeId);
        //}



        #endregion Methods
    }
}