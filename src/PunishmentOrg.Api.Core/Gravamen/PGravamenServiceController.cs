using Anu.BaseInfo.DataModel.Attachment;
using Anu.BaseInfo.DataModel.Security.Role;
using Anu.BaseInfo.DataModel.SystemConfiguration;
using Anu.BaseInfo.DataModel.SystemObject;
using Anu.BaseInfo.DataModel.Types;
using Anu.BaseInfo.Domain.GeoInfo;
using Anu.BaseInfo.Domain.OrganizationChart;
using Anu.BaseInfo.Domain.SystemObject;
using Anu.BaseInfo.ServiceModel.GeoInfo;
using Anu.BaseInfo.ServiceModel.Types;
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.Domain;
using Anu.PunishmentOrg.Api.Authentication;
using Anu.PunishmentOrg.Api.Authentication.Utility;
using Anu.PunishmentOrg.DataModel.Gravamen;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Anu.PunishmentOrg.Domain.Notice;
using Anu.PunishmentOrg.Domain.PGravamen;
using Anu.PunishmentOrg.Enumerations;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility.Extensions;
using Anu.Utility.Sms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Blockly.Model;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Utility;
using Utility.CalendarHelper;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    public class PGravamenServiceController : PGravamenServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor

        public PGravamenServiceController(Anu.DataAccess.IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides

        [AllowAnonymous]
        public async override Task<PGravamenServiceResponse> RecieveGravamen([FromBody] PGravamenServiceRequest request)
        {

            request.Null(PGravamenResult.PGravamen_Request_IsNullOrCorrupt);

            NullCheckNecessaryRequestFields(request);

            if (!await ArePeopleValid(request))
            {
                return Respond(PGravamenResult.PGravamen_NecessaryPositions_AreNotAvailabe);
            }

            var followupNumber = GenerateFollowUpNo(PU135OrWebSite.WebSite);
            List<string> plaintiffMobileNumber = new List<string>();

            var personList = new List<PGravamenPerson>();
            foreach (var person in request.ThePGravamenContract!.ThePGravamenPersonContractList!)
            {
                var rownumber = 1;
                PGravamenPerson currenPerson = new();
                switch (person.PersonStartPost)
                {
                    case PUPersonStartPost.PlaintiffPerson:
                    default:
                        currenPerson = new()
                        {
                            Id = Guid.NewGuid().ToString("N"),
                            Timestamp = 1,
                            RowNumber = rownumber,
                            Name = person?.Name,
                            Family = person?.Family,
                            Address = person?.Address,
                            BirthDate = person?.BirthDate,
                            FatherName = person?.FatherName,
                            IdentityNumber = person?.IdentityNumber,
                            MobilNumber = person?.MobilNumber,
                            NationalCode = person?.NationalCode,
                            Nationality = person?.Nationality,
                            PersonStartPost = PUPersonStartPost.PlaintiffPerson,
                            Sex = person?.Sex,
                            PersonType = Anu.BaseInfo.Enumerations.PersonType.NaturalPerson,
                            PostCode = person?.PostCode,
                            PersonPassword = "1",
                            TradeUnitName = string.Empty,
                        };

                        plaintiffMobileNumber.Add(person!.MobilNumber!);

                        break;

                    case PUPersonStartPost.OffendingPerson:

                        currenPerson = new()
                        {
                            Id = Guid.NewGuid().ToString("N"),
                            Timestamp = 1,
                            RowNumber = rownumber,
                            Name = "متخلف",
                            TradeUnitName = person.TradeUnitName,
                            PersonType = Anu.BaseInfo.Enumerations.PersonType.Legal,
                            PersonStartPost = PUPersonStartPost.OffendingPerson,
                            Family = string.Empty,
                            Address = person.Address,
                            BirthDate = string.Empty,
                            FatherName = string.Empty,
                            IdentityNumber = string.Empty,
                            MobilNumber = string.Empty,
                            NationalCode = string.Empty,
                            Nationality = Anu.BaseInfo.Enumerations.LNationality.None,
                            Sex = Anu.BaseInfo.Enumerations.SexType.None,
                            PostCode = string.Empty,
                            PersonPassword = "1",

                        };


                        break;

                }

                personList.Add(currenPerson);
                rownumber++;
            }

            var attachmentList = new List<PGravamenAttachment>();

            int docFilesLength = 0;
            foreach (var attachment in request.ThePGravamenContract!.TheGAttachmentContractList!)
            {
                //todo: should be fix this bug in client and then in the backend should be refactore this section
                if (!attachment.TheGAttachmentDataContract.Null())
                {
                    if (!attachment!.TheGAttachmentDataContract!.DocFile.Null())
                    {
                        var docFile = attachment.TheGAttachmentDataContract!.DocFile;
                        docFile.NullOrEmpty(PGravamenResult.PGravamen_NoFileIsAttached);

                        docFilesLength += docFile!.Length;

                        var validateDocFilesSize = ValidateDocFilesSize(docFilesLength);
                        if (!validateDocFilesSize.Null())
                        {
                            return validateDocFilesSize;
                        }


                        var attachmentType = await _unitOfWork.Repositorey<IGenericRepository<AttachmentType>>().GetById(Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.AttachmentTypeId.GravamenAttachmentTypeId);



                        var attachedFile = new PGravamenAttachment()
                        {
                            Id = Guid.NewGuid().ToString("N"),
                            Timestamp = 1,
                            FileExtension = attachment.FileExtension,
                            SaveAttachmentType = Anu.BaseInfo.Enumerations.SaveAttachmentType.SaveInDataBase,
                            CreateDateTime = DateTime.Now.ToPersianDateTime().ToString(),
                            TheAttachmentType = attachmentType,
                            Title = attachment.Title,
                            //SecondMili = attachment.SecondMili,
                            TheGAttachmentData = new GAttachmentData()
                            {
                                Id = Guid.NewGuid().ToString("N"),
                                Timestamp = 1,
                                DocFile = attachment.TheGAttachmentDataContract!.DocFile

                            }
                        };
                        attachedFile.TheAttachmentType = attachmentType;


                        attachmentList.Add(attachedFile);
                    }

                }
            }

            var gravamen = new PGravamen()
            {
                Id = Guid.NewGuid().ToString("N"),
                Timestamp = 1,
                TheObjectState = await _unitOfWork.Repositorey<IObjectStateRepository>().GetById(PunishmentOrgObjectState.PGravamen.PermanentRegisteredByApplicant),
                PetitionSubject = request.ThePGravamenContract.PetitionSubject,
                PetitionDescription = request.ThePGravamenContract.PetitionDescription,
                NoticeText = request.ThePGravamenContract.NoticeText,
                PetitionReasons = request.ThePGravamenContract.PetitionReasons,
                RejectReasonText = request.ThePGravamenContract.RejectReasonText,
                ReporterName = string.Empty,
                ReporterFamily = string.Empty,
                ReporterMobilNumber = string.Empty,

                ThePGravamenPersonList = personList,
                ThePGravamenAttachmentList = attachmentList.Count == 0 ? null : attachmentList,

                CreateDateTime = DateTime.Now.ToPersianDateTime(),
                FollowUpNo = followupNumber,
                HowDataType = PU135OrWebSite.WebSite,
                GravamenOrReport = Anu.PunishmentOrg.Enumerations.GravamenOrReport.Gravamen,
                TheReceiveUnit = await FindRelatedUnit(await _unitOfWork.Repositorey<IGeoLocationRepository>().GetGeoLocationWithLocationCode(request.ThePGravamenContract.TheGeoLocationContract!.LocationCode!)),

            };


            await _unitOfWork.Repositorey<IPGravamenRepository>().Add(gravamen);

            CreateWorkflowForSecretariat(gravamen);

            _unitOfWork.Complete();

            foreach (var item in plaintiffMobileNumber)
            {
                await SendConfirmationSms(item, gravamen.FollowUpNo);
            }


            return Respond(AnuResult.Successful, followupNumber);


        }

        [AllowAnonymous]
        public async override Task<GetPGravamenInfoResponse> GetPGravamenInfo([FromBody] GetPGravamenInfoRequest request)
        {
            GetPGravamenInfoResponse theGetPGravamenInfoResponse = new GetPGravamenInfoResponse();

            request.Null(GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_Request_Is_Required);

            request.TheGetPGravamenInfoContract.Null(GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_ThePGravamenContract_Is_Required);

            request.TheGetPGravamenInfoContract!.FollowUpNo.NullOrWhiteSpace(GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_FollowUpNo_Is_Required);

            request.TheGetPGravamenInfoContract!.FollowUpNo!.IsDigit(GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_FollowUpNo_Is_Required);

            var thePGravamen = await _unitOfWork.Repositorey<IPGravamenRepository>().GetPGravamenByFollowUpNo(request.TheGetPGravamenInfoContract.FollowUpNo!.Trim());

            thePGravamen.Null(GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_PGravamen_NotFound);

            theGetPGravamenInfoResponse = new GetPGravamenInfoResponse()
            {
                ThePGravamenInfoContract = new PGravamenInfoContract()
                {
                    State = this.GetState(thePGravamen),
                    FilingCaseDesc = this.GetFilingCaseDesc(thePGravamen),
                    InitialCreationDesc = this.GetInitialCreationDesc(thePGravamen),
                    RejectReasonDesc = this.GetRejectReasonDesc(thePGravamen),
                    ReviewDesc = this.GetReviewDesc(thePGravamen),
                    CreateDateTime = thePGravamen.CreateDateTime,
                    FollowUpNo = thePGravamen.FollowUpNo,
                    PetitionDescription = thePGravamen.PetitionDescription,
                    PetitionSubject = thePGravamen.PetitionSubject,
                    RejectReasonText = thePGravamen.RejectReasonText,
                    TheObjectState = new Anu.BaseInfo.ServiceModel.SystemObject.ObjectStateContract()
                    {
                        Title = thePGravamen.TheObjectState?.Title,
                        Code = thePGravamen.TheObjectState?.Code
                    },
                    ThePCase = new ServiceModel.Case.PCaseContract()
                    {
                        No = thePGravamen.ThePCase?.No
                    },
                    TheReceiveUnit = new Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract()
                    {
                        UnitName = thePGravamen.TheReceiveUnit?.UnitName,
                        UnitNo = thePGravamen.TheReceiveUnit?.UnitNo
                    },
                    TheReferUnit = new Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract()
                    {
                        UnitName = thePGravamen.TheReferUnit?.UnitName
                    }

                },
                Result = AnuResult.Successful.GetResult(),

            };


            return theGetPGravamenInfoResponse;
        }

        [PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.Tazirat135Users)]
        //[AllowAnonymous]
        public async override Task<GetPersonPGravamensInfoResponse> GetPersonPGravamenInfo([FromBody] GetPersonPGravamensInfoRequest request)
        {
            request.Null(GetPersonPGravamenInfoResult.PGravamen_GetPersonPGravamenInfoResult_Request_Is_Required);

            request.TheGetPersonPGravamenInfoContract.Null(GetPersonPGravamenInfoResult.PGravamen_GetPersonPGravamenInfoResult_TheGetPersonPGravamenInfoContract_Is_Required);

            request.TheGetPersonPGravamenInfoContract!.NationalityCode.NullOrWhiteSpace(GetPersonPGravamenInfoResult.PGravamen_GetPersonPGravamenInfoResult_PersonNationalityCode_Is_Required);

            request.TheGetPersonPGravamenInfoContract!.NationalityCode!.IsDigit(GetPersonPGravamenInfoResult.PGravamen_GetPersonPGravamenInfoResult_PersonNationalityCode_Not_Valid);

            var thePGravamenList = await _unitOfWork.Repositorey<IPGravamenRepository>().GetPGravamenByPersonNationalCode(request.TheGetPersonPGravamenInfoContract.NationalityCode!.Trim().ToString(), request.Page);

            thePGravamenList.Null(GetPersonPGravamenInfoResult.PGravamen_GetPersonPGravamenInfoResult_PGravamens_NotFound);

            var thePGravamenInfoContractList = thePGravamenList.Select(a => new PGravamenInfoContract()
            {
                CreateDateTime = a.CreateDateTime,
                TheObjectState = new Anu.BaseInfo.ServiceModel.SystemObject.ObjectStateContract()
                {
                    Code = a.TheObjectState.Code,
                    Title = a.TheObjectState.Title
                },
                State = this.GetState(a),
                FilingCaseDesc = this.GetFilingCaseDesc(a),
                InitialCreationDesc = this.GetInitialCreationDesc(a),
                RejectReasonDesc = this.GetRejectReasonDesc(a),
                ReviewDesc = this.GetReviewDesc(a),
                FollowUpNo = a.FollowUpNo,
                PetitionDescription = a.PetitionDescription,
                PetitionSubject = a.PetitionSubject,
                RejectReasonText = a.RejectReasonText,
                ThePCase = new ServiceModel.Case.PCaseContract()
                {
                    No = a.ThePCase?.No
                },
                TheReceiveUnit = new Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract()
                {
                    UnitName = a.TheReceiveUnit?.UnitName,
                    UnitNo = a.TheReceiveUnit?.UnitNo
                },
                TheReferUnit = new Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract()
                {
                    UnitName = a.TheReferUnit?.UnitName
                }

            }
            ).ToList();

            return new GetPersonPGravamensInfoResponse
            {
                ThePGravamenInfoContractList = new Page<List<PGravamenInfoContract>>
                {
                    Paged = request.Page,
                    Data = thePGravamenInfoContractList
                },
                Result = AnuResult.Successful.GetResult()
            };
        }

        [AllowAnonymous]
        public async override Task<GetPGravamenByIdResponse> GetPGravamenById([FromBody] GetPGravamenByIdRequest request)
        {
            request.Null(GetPGravamenByIdResult.PGravamen_GetPGravamenById_Request_Is_Required);

            request.ThePGravamenByIdContract.Null(GetPGravamenByIdResult.PGravamen_GetPGravamenById_ThePGravamenByIdContract_Is_Required);

            if (string.IsNullOrEmpty(request.ThePGravamenByIdContract!.Id) &&
                string.IsNullOrEmpty(request.ThePGravamenByIdContract!.FollowUpNo))
            {
                request.ThePGravamenByIdContract!.Id.NullOrWhiteSpace(GetPGravamenByIdResult.PGravamen_GetPGravamenById_Id_FollowUpNo_Is_Required);
            }

            PGravamen thePGravamen;
            if (!string.IsNullOrEmpty(request.ThePGravamenByIdContract!.Id))
            { 
                thePGravamen = await _unitOfWork.Repositorey<IPGravamenRepository>().GetPGravamenById(request.ThePGravamenByIdContract.Id!.Trim());
            }
            else
            {
                thePGravamen = await _unitOfWork.Repositorey<IPGravamenRepository>().GetPGravamenByFollowUpNo(request.ThePGravamenByIdContract.FollowUpNo!.Trim());
            }

            thePGravamen.Null(GetPGravamenByIdResult.PGravamen_GetPGravamenById_PGravamen_NotFound);

            return new GetPGravamenByIdResponse()
            {
                Result               = AnuResult.Successful.GetResult(),
                ThePGravamenContract = new PGravamenContract()
                {
                    PetitionSubject                = thePGravamen.PetitionSubject,
                    PetitionDescription            = thePGravamen.PetitionDescription,
                    NoticeText                     = thePGravamen.NoticeText,
                    PetitionReasons                = thePGravamen.PetitionReasons,
                    RejectReasonText               = thePGravamen.RejectReasonText,
                    CreateDateTime                 = thePGravamen.CreateDateTime,
                    FollowUpNo                     = thePGravamen.FollowUpNo,
                    HowDataType                    = thePGravamen.HowDataType,
                    GravamenOrReport               = thePGravamen.GravamenOrReport,
                    TheGeoLocationContract         = null,
                    TheObjectStateContract         = new ServiceModel.ServiceContract.ObjectState()
                    { 
                        Code  = thePGravamen.TheObjectState?.Code,
                        Title = thePGravamen.TheObjectState?.Title,
                    },
                    ThePCaseContract       = new ServiceModel.ServiceContract.PCase()
                    { 
                        No = thePGravamen.ThePCase?.No
                    },
                    TheReceiveUnitContract = new ServiceModel.ServiceContract.Unit()
                    { 
                        LocationCode = thePGravamen.TheReceiveUnit?.Code,
                        LocationName = thePGravamen.TheReceiveUnit?.UnitName,
                    },
                    TheReferUnitContract = new ServiceModel.ServiceContract.Unit()
                    {
                        LocationCode = thePGravamen.TheReferUnit?.Code,
                        LocationName = thePGravamen.TheReferUnit?.UnitName,
                    },
                    ThePGravamenNoticeHstContractList = thePGravamen.ThePGravamenNoticeHstList?.Select(x => new PGravamenNoticeHstContract()
                    { 
                        IssueDateTime = x.IssueDateTime,
                        NoticeText    = x.NoticeText,
                        NoticeType    = x.NoticeType == null ? (Anu.PunishmentOrg.Enumerations.GravamenNoticeType?)null : (Anu.PunishmentOrg.Enumerations.GravamenNoticeType)x.NoticeType,
                    }).ToList(),
                    ThePGravamenRejectOrDefectRSContractList = thePGravamen.ThePGravamenRejectOrDefectRSList?.Select(x => new PGravamenRejectOrDefectRSContract()
                    {
                        ThePBGravamenRejectDefectType = new PBGravamenRejectDefectTypeContract() 
                        { 
                            Code           = x.ThePBGravamenRejectDefectType?.Code,
                            RejectOrDefect = x.ThePBGravamenRejectDefectType?.RejectOrDefect == null ? (Anu.PunishmentOrg.Enumerations.RejectOrDefect?)null : (Anu.PunishmentOrg.Enumerations.RejectOrDefect)x.ThePBGravamenRejectDefectType?.RejectOrDefect,
                            Title          = x.ThePBGravamenRejectDefectType?.Title,
                        }
                    }).ToList(),
                    ThePGravamenViolationContractList = thePGravamen.ThePGravamenViolationList?.Select(x => new PGravamenViolationContract()
                    {
                        SubjectTitle     = x.SubjectTitle,
                        ViolationPrice   = x.ViolationPrice,
                        ViolationDesc    = x.ViolationDesc,
                        ViolationDate    = x.ViolationDate,
                        ViolationAddress = x.ViolationAddress
                    }).ToList(),
                    ThePGravamenPersonContractList = thePGravamen.ThePGravamenPersonList?.Select(x => new PGravamenPersonContract()
                    {
                        Name            = x.Name,
                        Family          = x.Family,
                        Address         = x.Address,
                        BirthDate       = x.BirthDate,
                        FatherName      = x.FatherName,
                        IdentityNumber  = x.IdentityNumber,
                        MobilNumber     = x.MobilNumber,
                        NationalCode    = x.NationalCode,
                        Nationality     = x.Nationality,
                        PersonStartPost = x.PersonStartPost,
                        Sex             = (Anu.BaseInfo.Enumerations.SexType)(x.Sex == null ? Anu.BaseInfo.Enumerations.SexType.None : x.Sex),
                        PersonType      = x.PersonType,
                        PostCode        = x.PostCode,
                        PersonPassword  = x.PersonPassword,
                        TradeUnitName   = x.TradeUnitName,

                    }).ToList(),
                    TheGAttachmentContractList = thePGravamen.ThePGravamenAttachmentList?.Select(x => new Anu.BaseInfo.ServiceModel.Attachment.GAttachmentContract()
                    {
                        FileExtension             = x.FileExtension,
                        CreateDateTime            = x.CreateDateTime,
                        TheAttachmentTypeContract = new AttachmentTypeContract()
                        {
                            Code  = x.TheAttachmentType?.Code,
                            Title = x.TheAttachmentType?.Title,
                        },
                        TheGAttachmentDataContract = new Anu.BaseInfo.ServiceModel.Attachment.GAttachmentDataContract()
                        {
                            DocFile = x.TheGAttachmentData?.DocFile
                        },
                    }).ToList(),
                }
            };
        }

        [PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.Tazirat135Users)]
        //[AllowAnonymous]
        public async override Task<GetPersonPGravamenStatisticResponse> GetPersonPGravamenStatistic([Microsoft.AspNetCore.Mvc.FromBody] GetPersonPGravamenStatisticRequest request)
        {
            #region Validation
            request.Null(GetPersonPGravamenStatisticResult.PGravamen_GetPersonPGravamenStatisticResult_Request_Is_Required);
            request.TheGetPersonPGravamenInfoContract.Null(GetPersonPGravamenStatisticResult.PGravamen_GetPersonPGravamenStatisticResult_Request_Is_Required);
            request!.TheGetPersonPGravamenInfoContract!.NationalityCode.NullOrWhiteSpace(GetPersonPGravamenStatisticResult.PGravamen_GetPersonPGravamenStatisticResult_TheNationalityCode_Is_Required);
            request!.TheGetPersonPGravamenInfoContract!.NationalityCode!.IsDigit(GetPersonPGravamenStatisticResult.PGravamen_GetPersonPGravamenStatisticResult_TheNationalityCode_Is_Required);

            #endregion Validation

            var thePGravamenlistByPersonNationalityCode = await _unitOfWork.Repositorey<IPGravamenRepository>().GetPGravamenListByNationalCode(request.TheGetPersonPGravamenInfoContract.NationalityCode!);

            return new GetPersonPGravamenStatisticResponse()
            {
                Result = AnuResult.Successful.GetResult(),
                TheGetPersonPGravamenStatisticContract = GetStatisticPersonPGravamen(thePGravamenlistByPersonNationalityCode, request.TheGetPersonPGravamenInfoContract.NationalityCode)
            };
        }

        #endregion Overrides

        #region Methods
        private string GetState(PGravamen thePGravamen)
        {
            return thePGravamen.TheObjectState?.Title;
        }

        private string GetReviewDesc(PGravamen thePGravamen)
        {
            if (thePGravamen.TheObjectState?.Code == PunishmentOrgObjectState.PGravamen.Failed ||
                thePGravamen.TheObjectState?.Code == PunishmentOrgObjectState.PGravamen.RegisterCase)
            {
                return string.Empty;
            }

            return $"شکوائیه شماره {thePGravamen.FollowUpNo} در شعبه {thePGravamen.TheReceiveUnit?.UnitName} در حال بررسی است..";
        }

        private string GetRejectReasonDesc(PGravamen thePGravamen)
        {
            if (thePGravamen.TheObjectState?.Code != PunishmentOrgObjectState.PGravamen.Failed)
            {
                return string.Empty;
            }

            string rejectReason = thePGravamen.ThePGravamenRejectOrDefectRSList.OfType<PGravamenRejectOrDefectRS>()?.FirstOrDefault()?.ThePBGravamenRejectDefectType?.Title;

            return $"شکوائیه شماره {thePGravamen.FollowUpNo} به دلیل {rejectReason} رد شده است.";
        }

        private string GetInitialCreationDesc(PGravamen thePGravamen)
        {
            return $"شکوائیه شماره {thePGravamen.FollowUpNo} در تاریخ  {thePGravamen.CreateDateTime?.Substring(0, 10)}  ثبت شده است. ";
        }

        private string GetFilingCaseDesc(PGravamen thePGravamen)
        {
            if (thePGravamen.TheObjectState?.Code != PunishmentOrgObjectState.PGravamen.RegisterCase)
            {
                return string.Empty;
            }

            return $"شکوائیه شماره {thePGravamen.FollowUpNo} در شعبه {thePGravamen.TheReceiveUnit?.UnitName} تشکیل پرونده شده است.";
        }

        private void NullCheckNecessaryRequestFields(PGravamenServiceRequest request)
        {
            var req = request.ThePGravamenContract;
            var errorResult = PGravamenResult.PGravamen_Field_IsNullOrInvalid;

            req!.PetitionSubject.NullOrWhiteSpace(errorResult, "موضوع شکایت");
            req!.PetitionDescription.NullOrWhiteSpace(errorResult, "شرح شکوائیه");
            req!.TheGeoLocationContract.Null(PGravamenResult.PGravamen_TheGeoLocation_IsRequired);
            req!.TheGAttachmentContractList.NullOrEmpty(PGravamenResult.PGravamen_NoAttachmentAvailable);
            req!.ThePGravamenPersonContractList.NullOrEmpty(PGravamenResult.PGravamen_Field_IsNullOrInvalid);
        }

        private async Task<bool> ArePeopleValid(PGravamenServiceRequest request)
        {
            var personList = request.ThePGravamenContract!.ThePGravamenPersonContractList;

            bool[] availablePositions = new bool[2];
            var plaintiffIndex = 0;
            var offendingIndex = 1;

            foreach (var person in personList!)
            {
                if (person.PersonStartPost == PUPersonStartPost.PlaintiffPerson)
                {
                    NullCheckNecessaryPersonFields(person, PUPersonStartPost.PlaintiffPerson);

                    await ShahkarAuthentication.ShahkarAuthenticate(person!.MobilNumber!, person!.NationalCode!);

                    availablePositions[plaintiffIndex] = true;
                }
                if (person.PersonStartPost == PUPersonStartPost.OffendingPerson)
                {
                    NullCheckNecessaryPersonFields(person, PUPersonStartPost.OffendingPerson);

                    availablePositions[offendingIndex] = true;
                }
            }
            if (availablePositions[plaintiffIndex] && availablePositions[offendingIndex])
            {
                return true;
            }


            return false;
        }

        private PGravamenServiceResponse? ValidateDocFilesSize(int totalSize)
        {
            if (!(totalSize / 1000 > 6000))
            {
                return null;
            }

            return Respond(PGravamenResult.PGravamen_FileIsLargerThanAllowedThreshold);
        }

        private string GenerateFollowUpNo(PU135OrWebSite howDataType)
        {
            /*
             * 
             * اگر شکوائیه از طریق سامانه تلفنی 135 ثبت شده باشد
             * شماره پیگیری می بایست با عدد 1 شروع شود ونه کاراکتر تصادفی دیگر خواهد داشت
             * 
             * 
             * اگر شکوائیه از طریق وب سایت اینترنتی ثبت شده باشد
             * شماره پیگیری می بایست با عدد 2 شروع شود ونه کاراکتر تصادفی دیگر خواهد داشت
             * 
             * شماره پیگیری می بایست 10 رقمی باشد
             * 
             */
            string followUpNo = "-1";
            if (howDataType == PU135OrWebSite.System135)
            {
                followUpNo = "1" + this.GetRandomNumber(9);
            }
            else if (howDataType == PU135OrWebSite.WebSite)
            {
                followUpNo = "2" + this.GetRandomNumber(9);
            }


            return followUpNo;
        }

        private async Task<Anu.BaseInfo.DataModel.OrganizationChart.Unit> FindRelatedUnit(Anu.BaseInfo.DataModel.GeoInfo.GeoLocation theGeoLocation)
        {

            Anu.BaseInfo.DataModel.OrganizationChart.Unit? receiverUnit = null;
            while (receiverUnit == null)
            {
                List<string> gunit = new List<string>();
                gunit.Add("003");
                gunit.Add("004");
                var Receiver = await _unitOfWork.Repositorey<IUnitRepository>().FindRelatedUnitToGeoLocation(theGeoLocation!.LocationCode!, gunit);

                if (Receiver == null)
                {
                    if (theGeoLocation.LocationType == Anu.BaseInfo.Enumerations.LocationType.Province)
                    {
                        var pBCountyLocatedUnit = await _unitOfWork.Repositorey<IPBCountyLocatedUnitRepository>()
                            .GetRelatedPBCountyLocatedUnitToGeolocationWithLocationCode(theGeoLocation.LocationCode!);
                        if (!pBCountyLocatedUnit.Null())
                        {
                            receiverUnit = pBCountyLocatedUnit.TheUnit!;
                        }
                        else
                        {
                            theGeoLocation = theGeoLocation.TheParentLocation!;
                        }
                    }
                    else
                    {
                        theGeoLocation = theGeoLocation.TheParentLocation!;
                    }
                }
                else
                {
                    receiverUnit = Receiver;
                }
            }

            return receiverUnit;
        }

        private async void CreateWorkflowForSecretariat(PGravamen pGravamen)
        {
            try
            {
                var baseRole = await _unitOfWork.Repositorey<IGenericRepository<BaseRole>>().GetById(PunishmentOrgActivities.PGravamen.RegisterInputGravamen);

                var systemObject = await _unitOfWork.Repositorey<IGenericRepository<SystemObject>>().GetById(Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.SystemObjectId.PGravamenSystemObjectId);

                var systemForm = await _unitOfWork.Repositorey<IGenericRepository<SystemForm>>().GetById(Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.SystemFormId.PGravamenSystemFormId);

                var maxDefaultDate = "9999/99/99";

                WorkFlowInstanceWorkItem workFlow = new()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Timestamp = 1,
                    ActivateDate = DateTime.Now.ToPersianDateTime().Substring(0, 10),
                    TheBaseRole = baseRole,
                    Description = baseRole.Name,
                    MaxDelayDate = maxDefaultDate,
                    SecurityOrganizationId = pGravamen!.TheReceiveUnit!.TheCMSOrganizationList![0].Id,
                    Title = baseRole.Name,
                    RelatedCaseId = string.Empty,
                    RelatedCaseNo = string.Empty,
                    TheRelatedSystemObjectCase = null,
                    TheRelatedDocObject = systemObject,
                    RelatedDocId = pGravamen.Id,
                    RelatedDocNo = pGravamen.FollowUpNo,
                    TheRelatedDocForm = systemForm,
                    State = Anu.BaseInfo.Enumerations.WorkFlowActivityInstanceState.Processing,
                    Type = Anu.BaseInfo.Enumerations.WorkFlowWorkItemType.NonWorkFlow,
                    UserCanDelay = Anu.BaseInfo.Enumerations.YesNo.Yes,
                    KeyField1 = "temp1",
                    KeyField2 = "temp2",
                    TheRelatedCMSUser = null,
                    TheRelatedCMSUserRoleType = null,
                    CreateDateTime = DateTime.Now.ToPersianDateTime(),

                };

                await _unitOfWork.Repositorey<IGenericRepository<WorkFlowInstanceWorkItem>>().Add(workFlow);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private async Task SendConfirmationSms(string reporterMobileNo, string followupNo)
        {
            var smsText = string.Format("کاربر گرامی، شکوائیه شما با شماره {0} ثبت گردید", followupNo);
            await SmsSender.SendSms(reporterMobileNo, smsText);
        }

        private string GetRandomNumber(int length)
        {
            string allowedChars = "0123456789";
            char[] chars = new char[length];
            var rd = new Random();
            for (int i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }

        private PGravamenServiceResponse Respond(PGravamenResult result)
        {
            var response = new PGravamenServiceResponse() { Result = result.GetResult() };
            return response;
        }

        private PGravamenServiceResponse Respond(AnuResult result, string followupNumber = "-1")
        {
            var response = new PGravamenServiceResponse()
            {
                Result = result.GetResult(),

                ThePGravamenResponseContract = new PGravamenResponseContract()
                {
                    FollowUpNo = followupNumber
                }
            };

            return response;
        }

        private void NullCheckNecessaryPersonFields(PGravamenPersonContract person, PUPersonStartPost startPosition)
        {
            switch (startPosition)
            {
                case PUPersonStartPost.PlaintiffPerson:
                    var errorCode = PGravamenResult.PGravamen_PlatiffNecessaryField_IsNullOrInvalid;
                    person.Name.NullOrWhiteSpace(errorCode, "نام");
                    person.Family.NullOrWhiteSpace(errorCode, "نام خانوادگی");
                    person.BirthDate.NullOrWhiteSpace(errorCode, "تاریخ تولد");
                    person.NationalCode.NullOrWhiteSpace(errorCode, "کد ملی");
                    person.MobilNumber.NullOrWhiteSpace(errorCode, "تلفن همراه");
                    person.Sex.Null(errorCode, "جنسیت");
                    person.Address.NullOrWhiteSpace(errorCode, "ادرس");
                    break;

                case PUPersonStartPost.OffendingPerson:
                    errorCode = PGravamenResult.PGravamen_OffendingNecessaryField_IsNullOrInvalid;
                    person.Address.NullOrWhiteSpace(errorCode, "آدرس متخلف");
                    person.TradeUnitName.NullOrWhiteSpace(errorCode, "نام واحد صنفی متخلف");
                    break;
            }
        }

        private GetPersonPGravamenStatisticContract GetStatisticPersonPGravamen(IEnumerable<Anu.PunishmentOrg.DataModel.Gravamen.PGravamen> pGravamen, string nationalityCode)
        {
            int totalCountPGravamenPerson = 0;
            int countRejectedPGravamenPerson = 0;
            int countPendingPGravamenPerson = 0;

            #region TotalCountPGravamenPerson
            totalCountPGravamenPerson = pGravamen.Count();
            #endregion TotalCountPGravamenPerson

            #region CountRejectedPGravamenPerson
            countRejectedPGravamenPerson = pGravamen.Where(x => x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.Failed
                                                            || x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.Failing).Count();
            #endregion CountRejectedPGravamenPerson

            #region CountPendingPGravamenPerson
            countPendingPGravamenPerson = pGravamen.Where(x => x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.Start
                                                        || x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.TemporaryRegisteredByApplicant
                                                        || x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.PermanentRegisteredByApplicant
                                                        || x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.RegisterPlaintiff
                                                        || x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.RegisterInput
                                                        || x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.Referred
                                                        || x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.Send
                                                        || x.TheObjectState.Code == PunishmentOrgObjectState.PGravamen.RegisterCase).Count(); 
            #endregion CountPendingPGravamenPerson

            return new GetPersonPGravamenStatisticContract()
            {
                TotalCountPGravamenPerson = totalCountPGravamenPerson,
                CountPendingPGravamenPerson = countPendingPGravamenPerson,
                CountRejectedPGravamenPerson = countRejectedPGravamenPerson,
                PersonNationalityCode = nationalityCode,
            };
        }
        #endregion Methods

    }
}