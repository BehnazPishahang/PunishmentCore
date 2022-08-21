
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Commons.Validations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.DataAccess.PGravamen;
using Anu.PunishmentOrg.DataModel.Gravamen;
using Anu.PunishmentOrg.Enumerations;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
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

        public async override Task<PGravamenServiceResponse> RecieveGravamen([FromBody] PGravamenServiceRequest request)
        {
            var response = new PGravamenServiceResponse()
            {
                Result = new Commons.ServiceModel.ServiceResponse.Result()
            };

            try
            {
                request.Null(PGravamenResult.PGravamen_Request_IsNullOrCorrupt);

                NullCheckNecessaryFields(request);

                if (!AreNecessaryStartPositionsAvailable(request))
                {
                    return Respond(PGravamenResult.PGravamen_NecessaryPositions_AreNotAvailabe);
                }

                var followupNumber = GenerateFollowUpNo(PU135OrWebSite.WebSite);
                var gravamen = new PGravamen()
                {
                    PetitionSubject = request.ThePGravamenContract.PetitionSubject,
                    PetitionDescription = request.ThePGravamenContract.PetitionDescription,
                    NoticeText = request.ThePGravamenContract.NoticeText,
                    PetitionReasons = request.ThePGravamenContract.PetitionReasons,
                    RejectReasonText = request.ThePGravamenContract.RejectReasonText,
                    ReporterName = request.ThePGravamenContract.ReporterName,
                    ReporterFamily = request.ThePGravamenContract.ReporterFamily,
                    ReporterMobilNumber = request.ThePGravamenContract.ReporterMobilNumber,

                    CreateDateTime = CalendarHelper.DateTimeNow().ToString(),
                    FollowUpNo = followupNumber,
                    HowDataType = PU135OrWebSite.WebSite,
                    GravamenOrReport = request.ThePGravamenContract.GravamenOrReport,
                };


                //await _unitOfWork.Repositorey<PGravamenRepository>().Add(gravamen);

                return Respond(AnuResult.Successful);
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

        private bool AreNecessaryStartPositionsAvailable(PGravamenServiceRequest request)
        {
            var personList = request.ThePGravamenContract.ThePGravamenPersonContractList;

            bool[] availablePositions = new bool[2];
            //var positionList = new List<string>();
            var plaintiffIndex = 0;
            var offendingIndex = 1;

            foreach (var person in personList)
            {
                if (person.Equals(nameof(PUPersonStartPost.PlaintiffPerson)))
                {
                    availablePositions[plaintiffIndex] = true;
                }
                if (person.Equals(nameof(PUPersonStartPost.OffendingPerson)))
                {
                    availablePositions[offendingIndex] = true;
                }
                //positionList.Add(nameof(person.PersonStartPost));
            }
            if (availablePositions[plaintiffIndex] && availablePositions[offendingIndex])
            {
                return true;
            }

            //if (positionList.Contains(nameof(PUPersonStartPost.PlaintiffPerson)) && positionList.Contains(nameof(PUPersonStartPost.OffendingPerson)))
            //{
            //    return true;
            //}

            return false;
        }

        private void NullCheckNecessaryFields(PGravamenServiceRequest request)
        {
            var req = request.ThePGravamenContract;
            var errorResult = PGravamenResult.PGravamen_Field_IsNullOrInvalid;

            req.PetitionSubject.NullOrWhiteSpace(errorResult, "موضوع شکوائیه");
            req.PetitionDescription.NullOrWhiteSpace(errorResult, "شرح شکوائیه");
            req.PetitionReasons.NullOrWhiteSpace(errorResult, "مدارک و مستندات");
            req.RejectReasonText.NullOrWhiteSpace(errorResult, "علت رد/نقص شکوائیه");
            req.NoticeText.NullOrWhiteSpace(errorResult, "متن آخرين ابلاغيه در مورد شکوائيه");
            req.ReporterName.NullOrWhiteSpace(errorResult, "نام گزارش دهنده");
            req.ReporterFamily.NullOrWhiteSpace(errorResult, "نام خانوادگی گزارش دهنده");
            req.ReporterMobilNumber.NullOrWhiteSpace(errorResult, "تلفن همراه گزارش دهنده");
        }

        #endregion Overrides

        #region Methods

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

                //FollowupNumber = followupNumber
            };
            return response;
        }

        #endregion Methods
    }
}