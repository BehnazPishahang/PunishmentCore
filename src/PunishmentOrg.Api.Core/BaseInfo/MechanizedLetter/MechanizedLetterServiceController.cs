using Anu.BaseInfo.DataModel.MechanizedLetter;
using Anu.BaseInfo.DataModel.SystemConfiguration;
using Anu.BaseInfo.Domain.ExchangeData;
using Anu.BaseInfo.Domain.MechanizedLetter;
using Anu.BaseInfo.Domain.OrganizationChart;
using Anu.BaseInfo.Domain.Security;
using Anu.BaseInfo.Domain.SystemConfiguration;
using Anu.BaseInfo.Domain.SystemObject;
using Anu.BaseInfo.ServiceModel.MechanizedLetter;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.Domain;
using Anu.PunishmentOrg.Domain.Case;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utility;
using Utility.CalendarHelper;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.BaseInfo.MechanizedLetter
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

        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        //[Permission(PunishmentOrgConstants.GFESUserAccessType.MechanizedLetterServices)]
        public async override Task<MechanizedLetterResponse> SendMechanizedLetter([FromBody] MechanizedLetterRequest request)
        {

            var OneMechanizedLetterResponse = new MechanizedLetterResponse();

            try
            {

                request.Null(MechanizedLetterResult.MechanizedLetter_Request_Is_Null);


                #region Validation

                #region GMechanizedLetterType

                request.TheGMechanizedLetterContract.TheGMechanizedLetterTypeContract.Code.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_GMechanizedLetterTypeCode_Is_null);
                var GMechanizedLetterType = await _unitOfWork.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(request.TheGMechanizedLetterContract.TheGMechanizedLetterTypeContract.Code);
                GMechanizedLetterType.Null(MechanizedLetterResult.MechanizedLetter_GMechanizedLetterTypeCode_Is_Not_Valid);

                #endregion

                #region [CreatorUserName]

                request.TheGMechanizedLetterContract.CreatorUserName.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_CreatorUserName_Is_Null);

                #endregion [CreatorUserName]

                #region TheSenderOuterOrg
                request.TheGMechanizedLetterContract.TheNAJAUnitContract.Code.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_NAJAUnit_Is_Null);
                var NajaUnit = await _unitOfWork.Repositorey<INAJAUnitRepository>().GetByCode(request.TheGMechanizedLetterContract.TheNAJAUnitContract.Code);
                NajaUnit.Null(MechanizedLetterResult.MechanizedLetter_SenderOuterOrgCode_Is_Not_Valid);
                #endregion

                #region [OuterOrgLetterDate]

                request.TheGMechanizedLetterContract.OuterOrgLetterDate.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_OuterOrgLetterDate_Is_Null);
                request.TheGMechanizedLetterContract.OuterOrgLetterDate.IsValidDate(MechanizedLetterResult.MechanizedLetter_OuterOrgLetterDate_Is_Not_ValidDate);

                #endregion [OuterOrgLetterDate]

                #region [OuterOrgLetterNo]
                request.TheGMechanizedLetterContract.OuterOrgLetterNo.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_OuterOrgLetterNo_Is_Null, args: "شماره نامه فرستنده را وارد نمایید.");
                request.TheGMechanizedLetterContract.OuterOrgLetterNo.IsDigit(MechanizedLetterResult.MechanizedLetter_OuterOrgLetterNo_Is_Not_Digit, args: "شماره نامه فرستنده از نوع عدد نمی باشد.");

                #endregion [OuterOrgLetterNo]

                #region [TheGMechanizedLetterReceiverList]

                request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList.NullOrEmpty(MechanizedLetterResult.MechanizedLetter_RecieveGMechanizedLetterServiceResult_Reciver_Is_Null);

                foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList)
                {
                    item.MainRcvOrTranscriptRcv.Null(MechanizedLetterResult.MechanizedLetter_mainRcvOrTranscriptRcv_Is_Null);
                    item.ReceiverType.Null(MechanizedLetterResult.MechanizedLetter_ReceiverType_Is_Null);

                    if (item.MainRcvOrTranscriptRcv != Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv.MainReceiver && item.MainRcvOrTranscriptRcv != Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv.TranscriptReceiver)
                        return Respond(MechanizedLetterResult.MechanizedLetter_mainRcvOrTranscriptRcv_Is_Not_Valid);

                    if (item.ReceiverType != Anu.BaseInfo.Enumerations.MechanizeRefererType.Unit
                        && item.ReceiverType != Anu.BaseInfo.Enumerations.MechanizeRefererType.UserPost
                        && item.ReceiverType != Anu.BaseInfo.Enumerations.MechanizeRefererType.PostRole)
                        return Respond(MechanizedLetterResult.MechanizedLetter_ReceiverType_Is_Not_Valid);
                }
                #endregion [TheGMechanizedLetterReceiverList]

                #region TheGMechanizedLetterCaseContractList
                foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterCaseContractList)
                {
                    item.RelatedCaseNo.Null(MechanizedLetterResult.MechanizedLetter_CaseNo_Is_Null);
                    item.TheunitContract.Null(MechanizedLetterResult.MechanizedLetter_TheUnit_Is_Null);
                    item.TheunitContract.Code.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_CaseUnit_Is_Null);

                    var CaseObj = await _unitOfWork.Repositorey<IPCaseRepository>().GetPCaseByNo(item.RelatedCaseNo);
                    CaseObj.Null(MechanizedLetterResult.MechanizedLetter_CaseNo_Is_Not_Valid);


                    var UnitObj = await _unitOfWork.Repositorey<IUnitRepository>().GetByCode(item.TheunitContract.Code);
                    UnitObj.Null(MechanizedLetterResult.MechanizedLetter_CaseUnit_Is_Not_Valid);


                }
                #endregion

                foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterRelLettersContractList)
                {
                    item.RelationType.Null(MechanizedLetterResult.MechanizedLetter_RelLetters_relationType_Is_Null);
                    item.RelLetterGetType.Null(MechanizedLetterResult.MechanizedLetter_RelLetters_RelLetterGetType_Is_Null);
                    item.RelLetterNo.Null(MechanizedLetterResult.MechanizedLetter_RelLetters_RelLetterNo_Is_Null);

                    if (item.RelationType != Anu.BaseInfo.Enumerations.MechanizedLetterRelType.Comeback &&
                        item.RelationType != Anu.BaseInfo.Enumerations.MechanizedLetterRelType.Follower)
                    {
                        return Respond(MechanizedLetterResult.MechanizedLetter_RelLetters_relationType_Is_Not_Valid);
                    }

                    if (item.RelLetterGetType != Anu.BaseInfo.Enumerations.MechanizedLetterRelLetterGetType.NonMechanize
                        && item.RelLetterGetType != Anu.BaseInfo.Enumerations.MechanizedLetterRelLetterGetType.Mechanize)
                    {
                        return Respond(MechanizedLetterResult.MechanizedLetter_RelLetters_RelLetterGetType_Is_Not_Valid);
                    }

                    var GMechanizedLetterObj = await _unitOfWork.Repositorey<IGMechanizedLetterRepository>().GetByNo(item.RelLetterNo);
                    GMechanizedLetterObj.Null(MechanizedLetterResult.MechanizedLetter_RelLetters_RelLetterNo_Is_Not_Valid);
                }

                #region [TheReceiverInnerOrg]
                foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList)
                {
                    if (item.TheCMSOrganizationContract.Code != null)
                    {
                        var OneCMSOrganization = await _unitOfWork.Repositorey<ICMSOrganizationRepository>().GetByCode(item.TheCMSOrganizationContract.Code);

                        if (OneCMSOrganization == null)
                        {
                            return Respond(MechanizedLetterResult.MechanizedLetter_TheReceiverInnerOrgCode_Is_Not_Valid);

                        }
                    }
                }
                #endregion [TheReceiverInnerOrg]

                #region LetterText

                request.TheGMechanizedLetterContract.LetterText.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_LetterText_Is_Null);

                #endregion

                #endregion

                #region CreateGMechanizedLetter
                GMechanizedLetter OneGMechanizedLetter = new()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Timestamp = 1,
                    CreateDateTime = CalendarHelper.GetCurrentDateTime(),
                    OuterOrgLetterNo = request.TheGMechanizedLetterContract.OuterOrgLetterNo is null ? null : request.TheGMechanizedLetterContract.OuterOrgLetterNo,
                    OuterOrgLetterDate = request.TheGMechanizedLetterContract.OuterOrgLetterDate is null ? null : request.TheGMechanizedLetterContract.OuterOrgLetterDate,
                    LetterText = request.TheGMechanizedLetterContract.LetterText,
                    IsSendByOuterOrg = Anu.BaseInfo.Enumerations.YesNo.Yes,
                    CreatorUserName = request.TheGMechanizedLetterContract.CreatorUserName,
                    TheObjectState = await _unitOfWork.Repositorey<IObjectStateRepository>().GetById(PunishmentOrgObjectState.PMechanizeLetter.ConfirmedToSend),
                };

                #region GMechanizedLetterType 

                OneGMechanizedLetter.TheGMechanizedLetterType = GMechanizedLetterType is null ? null : GMechanizedLetterType;
                #endregion

                #region NajaUnit

                OneGMechanizedLetter.TheSenderOuterOrg = NajaUnit is null ? null : NajaUnit;
                #endregion

                #region Case
                foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterCaseContractList)
                {
                    OneGMechanizedLetter.TheGMechanizedLetterCaseList = new();
                    var Unit = await _unitOfWork.Repositorey<IUnitRepository>().GetByCode(item.TheunitContract.Code);
                    var CaseList = await _unitOfWork.Repositorey<IPCaseRepository>().GetPCaseByNo(item.RelatedCaseNo);
                    var OneCaseId = "";
                    foreach (var caseItem in CaseList)
                    {
                        if (caseItem.TheHandlerUnit.Id == Unit.Id)
                        {
                            OneCaseId = caseItem.Id;

                        }
                    }
                    OneCaseId.NullOrWhiteSpace(MechanizedLetterResult.MechanizedLetter_CaseHandlerUnitId_Is_Not_Sync_UnitId);
                    var GMechanizedLetterCase = new GMechanizedLetterCase()
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        TheUnit = Unit,
                        RelatedCaseNo = item.RelatedCaseNo,
                        RelatedCaseTitle = item.RelatedCaseTitle,
                        CaseLocation = Anu.BaseInfo.Enumerations.MechanizedLetterCaseLocation.Destination,
                        TheRelatedCaseClass = await _unitOfWork.Repositorey<ISystemObjectRepository>().GetById("21c7d5f0a1524460898a56c0417e0755"),
                        TheRelatedCaseForm = await _unitOfWork.Repositorey<ISystemFormRepository>().GetById("5A1F4099A1B6437BA5E1D568000A751C"),
                        RelatedCaseID = OneCaseId,

                    };
                    OneGMechanizedLetter.TheGMechanizedLetterCaseList.Add(GMechanizedLetterCase);
                }
                #endregion

                #region RelLetters
                foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterRelLettersContractList)
                {
                    OneGMechanizedLetter.TheRelLettersList = new();
                    var GMechanizedLetterObj = await _unitOfWork.Repositorey<IGMechanizedLetterRepository>().GetByNo(item.RelLetterNo);
                    var oneGMechanizedLetterRelLetters = new GMechanizedLetterRelLetters()
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        RelationType = item.RelationType,
                        RelLetterDate = item.RelLetterDate,
                        RelLetterGetType = item.RelLetterGetType,
                        RelLetterNo = item.RelLetterNo,
                        TheMainLetter = OneGMechanizedLetter,
                        TheRelLetter = GMechanizedLetterObj,

                    };

                    OneGMechanizedLetter.TheRelLettersList.Add(oneGMechanizedLetterRelLetters);
                }
                #endregion

                #region GMechanizedLetterFieldsContractList

                foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterFieldsContractList)
                {
                }

                #endregion

                #region GMechanizedLetterReceiver

                foreach (var item in request.TheGMechanizedLetterContract.TheGMechanizedLetterReceiverContractList)
                {
                    var ReceiverInnerOrg = await _unitOfWork.Repositorey<ICMSOrganizationRepository>().GetByCode(item.TheCMSOrganizationContract.Code);
                    var CMSUserRoleType = await _unitOfWork.Repositorey<ICMSUserRoleTypeRepository>().GetByCode(item.TheCMSUserRoleTypeContract.Code);
                    var MaxNo = await _unitOfWork.Repositorey<IGMechanizedLetterRepository>().GetMaxNo(CalendarHelper.GetCurrentDate().Substring(0, 4), item.TheCMSOrganizationContract.Code);
                    OneGMechanizedLetter.TheGMechanizedLetterReceiverList = new();
                    var oneGMechanizedLetterReceiver = new GMechanizedLetterReceiver()
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        IsMechanizeRelation = Anu.BaseInfo.Enumerations.YesNo.Yes,
                        InnerOrOutterRcvType = Anu.BaseInfo.Enumerations.MechanizedLetterReceiverType.InnerOrg,
                        MainRcvOrTranscriptRcv = item.MainRcvOrTranscriptRcv,
                        ReceiverType = item.ReceiverType,
                        SendDateTime = CalendarHelper.GetCurrentDateTime(),
                        ViewDateTime = "9999/99/99-99:99",
                        TheObjectState = await _unitOfWork.Repositorey<IObjectStateRepository>().GetById(PunishmentOrgObjectState.PMechanizeLetter.ReceivedByReceiverUnit),
                        TheReceiverInnerOrg = ReceiverInnerOrg is null ? null : ReceiverInnerOrg,
                        TheReceiverPost = CMSUserRoleType is null ? null : CMSUserRoleType

                    };
                    OneGMechanizedLetter.TheGMechanizedLetterReceiverList.Add(oneGMechanizedLetterReceiver);
                    OneGMechanizedLetter.No = MaxNo;


                    #region DefineWorkItemsForMechanizeLetter
                    string relatedCMSUserId = null;
                    string relatedCMSOrgId = null;
                    string OneNAJAUnit = null;
                    string relatedCMSUserRoleTypeId = null;
                    string vGUID = Guid.NewGuid().ToString().Replace("-", string.Empty);

                    //todo
                    //if (item.TheReceiverUserAndPost != null)
                    //    relatedCMSUserId = item.TheReceiverUserAndPost.TheCmsUserContract.id;

                    #region Inner
                    if (oneGMechanizedLetterReceiver.InnerOrOutterRcvType == Anu.BaseInfo.Enumerations.MechanizedLetterReceiverType.InnerOrg)
                    {
                        #region CMSOrganization
                        var OneCMSOrganization = await _unitOfWork.Repositorey<ICMSOrganizationRepository>().GetByCode(item.TheCMSOrganizationContract.Code);
                        relatedCMSOrgId = OneCMSOrganization.Id;
                        #endregion

                        #region CMSUserRoleType

                        if (CMSUserRoleType != null)
                            relatedCMSUserRoleTypeId = CMSUserRoleType.Id;

                        #endregion

                        #region CMSUser
                        //todo
                        //if (item.TheReceiverUserAndPost != null)
                        //{
                        //    var OnerelatedCMSUserRoleType = await _unitOfWork.CMSUserRoleType.GetByCode(item.TheCMSUserRoleTypeContract.Code);
                        //    relatedCMSUserRoleTypeId = OnerelatedCMSUserRoleType.Id;
                        //}
                        //relatedCMSUserId = item.TheReceiverUserAndPost.TheCmsUserContract.ObjectId;

                        #endregion

                        #region واحد


                        var Unit = await _unitOfWork.Repositorey<IUnitRepository>().GetByCode(ReceiverInnerOrg.TheUnit.Code);

                        if (item.ReceiverType == Anu.BaseInfo.Enumerations.MechanizeRefererType.Unit)
                        {

                            DefineWorkItemsForMechanizeLetter(Anu.Constants.ServiceModel.PunishmentOrg.PunishmentOrgActivities.MechanizedLetter.ViewOrRefer
                               , OneGMechanizedLetter
                               , relatedCMSUserId
                               , relatedCMSOrgId
                               , Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.SystemFormId.RecieveMechanizedLetterSystemFormId
                               , relatedCMSUserRoleTypeId, true, vGUID, Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.SystemObjectId.RecieveMechanizedLetterSystemObjectId, oneGMechanizedLetterReceiver.Id);
                        }
                        #endregion

                        #region سمت
                        else if (item.ReceiverType == Anu.BaseInfo.Enumerations.MechanizeRefererType.PostRole)
                        {

                            DefineWorkItemsForMechanizeLetter(Anu.Constants.ServiceModel.PunishmentOrg.PunishmentOrgActivities.MechanizedLetter.ViewOrRefer
                                , OneGMechanizedLetter
                                , relatedCMSUserId
                                , relatedCMSOrgId
                                , Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.SystemFormId.RecieveMechanizedLetterSystemFormId
                                , relatedCMSUserRoleTypeId, true, vGUID, Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.SystemObjectId.RecieveMechanizedLetterSystemObjectId, oneGMechanizedLetterReceiver.Id);
                        }

                        #endregion

                        #region کاربر
                        else if (item.ReceiverType == Anu.BaseInfo.Enumerations.MechanizeRefererType.UserPost)
                        {
                            //relatedCMSUserId = item.TheReceiverUserAndPost.TheCmsUserContract.ObjectId;

                            //DefineWorkItemsForMechanizeLetter(Anu.Constants.ServiceModel.PunishmentOrg.PunishmentOrgActivities.MechanizedLetter.ViewOrRefer
                            //    , OneGMechanizedLetter
                            //    , relatedCMSUserId
                            //    , relatedCMSOrgId
                            //    , "9003239250EA48C3A583FA2DAC0D0E2C"//systemform
                            //    , relatedCMSUserRoleTypeId, true, vGUID, "8fc11d43c5a24efa8e209b3cc05ca450", oneGMechanizedLetterReceiver.Id);
                        }
                        #endregion
                    }
                    #endregion


                    #endregion

                }

                #endregion

                _unitOfWork.Repositorey<IGMechanizedLetterRepository>().Add(OneGMechanizedLetter);
                _unitOfWork.Complete();
                return Respond(AnuResult.Successful, OneGMechanizedLetter.No);

                #endregion


                return OneMechanizedLetterResponse;


            }
            catch (AnuExceptions ex)
            {
                OneMechanizedLetterResponse.Result = ex.result;
                return OneMechanizedLetterResponse;
            }
            catch (DbUpdateException ex)
            {
                return new MechanizedLetterResponse() { Result = AnuResult.Error.GetResult(ex) };
            }
            catch (Exception ex)
            {
                return new MechanizedLetterResponse() { Result = AnuResult.Error.GetResult(ex) };
            }


        }
        #endregion Overrides

        #region Methods
        private MechanizedLetterResponse Respond(AnuResult result, string? no)
        {

            var response = new MechanizedLetterResponse()
            {
                Result = result.GetResult(),
                TheGMechanizedLetterOutputContract = new GMechanizedLetterOutputContract() { No = no }
            };
            return response;



        }
        private MechanizedLetterResponse Respond(MechanizedLetterResult result)
        {
            var response = new MechanizedLetterResponse() { Result = result.GetResult() };
            return response;
        }

        public async void DefineWorkItemsForMechanizeLetter(string baseRoleId
           , Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter MechanizedLetterObject
           , string RelatedCMSUserId = null
           , string RelatedOrganizationId = null
           , string SystemFormId = null
           , string RelatedCMSUserRoleTypeId = null
           , bool SameCaseServerForSenderAndReceiver = true
           , string WorkFlowInstanceWorkItemId = null
           , string RelatedDocObjectId = null
           , string RelatedDocId = null)
        {

            string CaseId = null;
            string CaseNo = null;
            string CaseSystemObjectId = null;

            if (MechanizedLetterObject.TheGMechanizedLetterCaseList.Count > 0)
            {
                CaseNo = MechanizedLetterObject.TheGMechanizedLetterCaseList[0].RelatedCaseNo;
                if (CaseNo.Length > 19)
                    CaseNo = CaseNo.Substring(0, 19);

                CaseId = MechanizedLetterObject.TheGMechanizedLetterCaseList[0].RelatedCaseID;

                CaseSystemObjectId = "b40dcb897f584550a24460272ced792f";//systemObject

            }

            var baseRole = await _unitOfWork.Repositorey<IBaseRoleRepository>().GetById(baseRoleId);

            string TempNo = "";
            await _unitOfWork.Repositorey<IWorkFlowInstanceWorkItemRepository>().Insert(
            DateTime.Now.ToPersian().Substring(0, 10),
            baseRole.Id,
            baseRole.Name,
            "9999/99/99",
            RelatedOrganizationId,
            baseRole.Name,
            CaseId,
            CaseNo,
            CaseSystemObjectId,
            RelatedDocObjectId,
            RelatedDocId,
            MechanizedLetterObject.No,
            SystemFormId,
            Anu.BaseInfo.Enumerations.WorkFlowActivityInstanceState.Processing,
            Anu.BaseInfo.Enumerations.WorkFlowWorkItemType.NonWorkFlow,
            Anu.BaseInfo.Enumerations.YesNo.Yes,
            TempNo,
            "",
            RelatedCMSUserId,
            RelatedCMSUserRoleTypeId,
            SameCaseServerForSenderAndReceiver,
            WorkFlowInstanceWorkItemId);

        }




        #endregion Methods
    }
}