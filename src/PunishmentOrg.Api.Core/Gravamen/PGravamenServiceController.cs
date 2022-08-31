
using Anu.BaseInfo.DataAccess.Security;
using Anu.BaseInfo.DataAccess.SystemConfiguration;
using Anu.BaseInfo.DataAccess.Unit;
using Anu.BaseInfo.DataModel.Attachment;
using Anu.BaseInfo.DataModel.GeoInfo;
using Anu.BaseInfo.DataModel.Security.Role;
using Anu.BaseInfo.DataModel.SystemConfiguration;
using Anu.BaseInfo.DataModel.SystemObject;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Commons.Validations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.DataAccess.Repositories;
using Anu.Domain;
using Anu.PunishmentOrg.DataAccess.PGravamen;
using Anu.PunishmentOrg.DataModel.Gravamen;
using Anu.PunishmentOrg.Enumerations;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility.Sms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.CalendarHelper;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    public class PGravamenServiceController : PGravamenServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor

        public PGravamenServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
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
            var response = new PGravamenServiceResponse()
            {
                Result = new Commons.ServiceModel.ServiceResponse.Result()
            };

            try
            {
                request.Null(PGravamenResult.PGravamen_Request_IsNullOrCorrupt);

                NullCheckNecessaryRequestFields(request);

                if (!AreNecessaryStartPositionsAvailable(request))
                {
                    return Respond(PGravamenResult.PGravamen_NecessaryPositions_AreNotAvailabe);
                }

                var followupNumber = GenerateFollowUpNo(PU135OrWebSite.WebSite);


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
                                //ToDo: should check shakar and sabtahval serivce for PlaintiffPerson type in personlist
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


                            break;

                        case PUPersonStartPost.OffendingPerson:

                            currenPerson = new()
                            {
                                Id = Guid.NewGuid().ToString("N"),
                                Timestamp = 1,
                                RowNumber = rownumber,
                                Name = person.Name,
                                TradeUnitName = person.TradeUnitName,
                                PersonType = Anu.BaseInfo.Enumerations.PersonType.Legal,
                                PersonStartPost = PUPersonStartPost.OffendingPerson,

                                Family = string.Empty,
                                Address = string.Empty,
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
                var gravamenAttachmentTypeId = "300";

                int docFilesLength = 0;
                foreach (var attachment in request.ThePGravamenContract!.TheGAttachmentContractList!)
                {
                    var docFile = attachment.TheGAttachmentDataContract.DocFile;

                    docFilesLength += docFile.Length;

                    docFile.NullOrEmpty(PGravamenResult.PGravamen_NoFileIsAttached);

                    var attachmentType = await _unitOfWork.Repositorey<GenericRepository<Anu.BaseInfo.DataModel.Types.AttachmentType>>().GetById(gravamenAttachmentTypeId);



                    var attachedFile = new PGravamenAttachment()
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        Timestamp = 1,
                        FileExtension = attachment.FileExtension,
                        SaveAttachmentType = Anu.BaseInfo.Enumerations.SaveAttachmentType.SaveInDataBase,
                        CreateDateTime = DateTime.Now.ToPersian().ToString(),
                        //TheAttachmentType = attachmentType,

                        TheGAttachmentData = new GAttachmentData()
                        {
                            Id = Guid.NewGuid().ToString("N"),
                            Timestamp = 1,
                            DocFile = attachment.TheGAttachmentDataContract!.DocFile

                        }
                    };
                    attachedFile.TheAttachmentType = attachmentType;
                    ValidateDocFilesSize(docFilesLength);

                    attachmentList.Add(attachedFile);
                }


                var gravamen = new PGravamen()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Timestamp = 1,
                    TheObjectState = await _unitOfWork.Repositorey<Anu.BaseInfo.DataAccess.SystemObject.ObjectStateRepository>().GetById(PunishmentOrgObjectState.PGravamen.Start),
                    PetitionSubject = request.ThePGravamenContract.PetitionSubject,
                    PetitionDescription = request.ThePGravamenContract.PetitionDescription,
                    NoticeText = request.ThePGravamenContract.NoticeText,
                    PetitionReasons = request.ThePGravamenContract.PetitionReasons,
                    RejectReasonText = request.ThePGravamenContract.RejectReasonText,
                    ReporterName = request.ThePGravamenContract.ReporterName,
                    ReporterFamily = request.ThePGravamenContract.ReporterFamily,
                    ReporterMobilNumber = request.ThePGravamenContract.ReporterMobilNumber,

                    ThePGravamenPersonList = personList,
                    ThePGravamenAttachmentList = attachmentList,

                    CreateDateTime = DateTime.Now.ToPersian().ToString(),
                    FollowUpNo = followupNumber,
                    HowDataType = PU135OrWebSite.WebSite,
                    GravamenOrReport = Anu.PunishmentOrg.Enumerations.GravamenOrReport.Gravamen,
                    TheReceiveUnit = await FindRelatedUnit(await _unitOfWork.Repositorey<Anu.BaseInfo.DataAccess.GeoInfo.GeoLocationRepository>().GetGeoLocationWithLocationCode(request.ThePGravamenContract.TheGeoLocationContract!.LocationCode)),

                };


                await _unitOfWork.Repositorey<PGravamenRepository>().Add(gravamen);

                CreateWorkflowForSecretariat(gravamen);

                _unitOfWork.Complete();

                await SendConfirmationSms(gravamen.ReporterMobilNumber!, gravamen.FollowUpNo);

                return Respond(AnuResult.Successful, followupNumber);
            }
            catch (AnuExceptions ex)
            {
                response.Result = ex.result;
                return response;
            }
            catch (Exception ex)
            {
                response.Result = AnuResult.Error.GetResult(ex);
                return response;
            }

        }


        #endregion Overrides

        #region Methods

        private void NullCheckNecessaryRequestFields(PGravamenServiceRequest request)
        {
            var req = request.ThePGravamenContract;
            var errorResult = PGravamenResult.PGravamen_Field_IsNullOrInvalid;

            req!.PetitionSubject.NullOrWhiteSpace(errorResult, "موضوع شکوائیه");
            req!.PetitionDescription.NullOrWhiteSpace(errorResult, "شرح شکوائیه");
            req!.PetitionReasons.NullOrWhiteSpace(errorResult, "مدارک و مستندات");
            req!.RejectReasonText.NullOrWhiteSpace(errorResult, "علت رد/نقص شکوائیه");
            req!.NoticeText.NullOrWhiteSpace(errorResult, "متن آخرين ابلاغيه در مورد شکوائيه");
            req!.ReporterName.NullOrWhiteSpace(errorResult, "نام گزارش دهنده");
            req!.ReporterFamily.NullOrWhiteSpace(errorResult, "نام خانوادگی گزارش دهنده");
            req!.ReporterMobilNumber.NullOrWhiteSpace(errorResult, "تلفن همراه گزارش دهنده");
            req!.TheGeoLocationContract.Null(PGravamenResult.PGravamen_TheGeoLocation_IsRequired);
            req!.TheGAttachmentContractList.NullOrEmpty(PGravamenResult.PGravamen_NoAttachmentAvailable);
            req!.ThePGravamenPersonContractList.NullOrEmpty(PGravamenResult.PGravamen_Field_IsNullOrInvalid);
        }
        private bool AreNecessaryStartPositionsAvailable(PGravamenServiceRequest request)
        {
            var personList = request.ThePGravamenContract.ThePGravamenPersonContractList;

            bool[] availablePositions = new bool[2];
            var plaintiffIndex = 0;
            var offendingIndex = 1;

            foreach (var person in personList)
            {
                PUPersonStartPost startPost;
                if (person.PersonStartPost == PUPersonStartPost.PlaintiffPerson)
                {
                    NullCheckNecessaryPersonFields(person, PUPersonStartPost.PlaintiffPerson);

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

            Anu.BaseInfo.DataModel.OrganizationChart.Unit receiverUnit = null;
            while (receiverUnit == null)
            {
                List<string> gunit = new List<string>();
                gunit.Add("003");
                gunit.Add("004");
                var Receiver = await _unitOfWork.Repositorey<Anu.BaseInfo.DataAccess.OrganizationChart.UnitRepository>().FindRelatedUnitToGeoLocation(theGeoLocation!.LocationCode, gunit);

                if (Receiver == null)
                {
                    if (theGeoLocation.LocationType == Anu.BaseInfo.Enumerations.LocationType.Province)
                    {
                        var pBCountyLocatedUnit = await _unitOfWork.Repositorey<Anu.PunishmentOrg.DataAccess.BaseInfo.PBCountyLocatedUnitRepository>()
                            .GetRelatedPBCountyLocatedUnitToGeolocationWithLocationCode(theGeoLocation.LocationCode);
                        if (!pBCountyLocatedUnit.Null())
                        {
                            receiverUnit = pBCountyLocatedUnit.TheUnit;
                        }
                        else
                        {
                            theGeoLocation = theGeoLocation.TheParentLocation;
                        }
                    }
                    else
                    {
                        theGeoLocation = theGeoLocation.TheParentLocation;
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
                var baseRole = await _unitOfWork.Repositorey<GenericRepository<BaseRole>>().GetById(PunishmentOrgActivities.PGravamen.RegisterInputGravamen);
                var systemObject = await _unitOfWork.Repositorey<GenericRepository<SystemObject>>().GetById(Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.SystemObjectId.PGravamenSystemObjectId);
                var systemForm = await _unitOfWork.Repositorey<GenericRepository<SystemForm>>().GetById(Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.SystemFormId.PGravamenSystemFormId);

                var maxDefaultDate = "9999/99/99";

                WorkFlowInstanceWorkItem workFlow = new()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Timestamp = 1,
                    ActivateDate = DateTime.Now.ToPersian().Substring(0, 10),
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
                    CreateDateTime = DateTime.Now.ToPersian(),

                };

                await _unitOfWork.Repositorey<GenericRepository<WorkFlowInstanceWorkItem>>().Add(workFlow);
            }
            catch (Exception ex)
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
                    person.Name.NullOrWhiteSpace(errorCode, "نام");
                    person.TradeUnitName.NullOrWhiteSpace(errorCode, "نام واحد صنفی");
                    break;
            }
        }



        #endregion Methods

    }
}