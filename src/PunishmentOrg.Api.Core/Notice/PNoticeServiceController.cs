
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Notice
{
    public class PNoticeServiceController : PNoticeServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor
        public PNoticeServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<PNoticeInqueryResponse> InqueryPNoticeList([FromBody] PNoticeInqueryRequest request)
        {
            try
            {

                request.PNoticePersonContract.NationalityCode.Null(PNoticeResult.NationalCodeIs_Required);

                var pNotice = await _unitOfWork.PNotice.GetAllPNoticeByNationalCode(request.PNoticePersonContract.NationalityCode.ToString(),request.Page);

                pNotice.Null(PNoticeResult.PNotice_NotFound);


                var pNoticeContractList = pNotice.Select(a => new PNoticeContract()
                {
                    CreateDateTime = a.CreateDateTime,
                    No = a.No,
                    NoticeDate = a.NoticeDate,
                    NoticePersonFamily = a.NoticePersonFamily,
                    NoticePersonName = a.NoticePersonName
                }
                ).ToList();

                return new PNoticeInqueryResponse { 
                    PNotice = new PNoticeInquery { Page = request.Page, PNoticeList = pNoticeContractList }, 
                    Result = AnuResult.Successful.GetResult() 
                };

            }
            catch (AnuExceptions ex)
            {
                return new PNoticeInqueryResponse() { Result = ex.result };
            }
            catch (Exception ex)
            {
                return new PNoticeInqueryResponse() { Result = AnuResult.Error.GetResult(ex) };
            }

        }
        #endregion Overrides

        #region Methods
        #endregion Methods
    }
}