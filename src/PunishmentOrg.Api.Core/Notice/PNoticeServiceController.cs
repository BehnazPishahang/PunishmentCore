
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataAccess.Notice;
using Anu.PunishmentOrg.DataModel.Notice;
using Anu.PunishmentOrg.Report;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.Report;
using Microsoft.AspNetCore.Mvc;
using Utility;
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
            request.Null(PNoticeResult.NationalCodeIs_Required);

            request.PNoticePersonContract.NationalityCode.Null(PNoticeResult.NationalCodeIs_Required);

            var pNotice = await _unitOfWork.Repositorey<PNoticeRepository>().GetAllPNoticeByNationalCode(request.PNoticePersonContract.NationalityCode.ToString(), request.Page);

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

            return new PNoticeInqueryResponse
            {
                PNotice = new Page<List<PNoticeContract>> { Paged = request.Page, Data = pNoticeContractList },
                Result = AnuResult.Successful.GetResult()
            };


        }

        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<PNoticeExportResponse> ExportPNotice([FromBody] PNoticeExportRequest request)
        {
            request.Null(PNoticeResult.No_Is_Required);
            request.PNoticeNoContract.No.NullOrWhiteSpace(PNoticeResult.No_Is_Required);

            var pNotice = (await _unitOfWork.Repositorey<GenericRepository<PNotice>>().Find(x=>x.No == request.PNoticeNoContract.No)).FirstOrDefault();

            pNotice.Null(PNoticeResult.PNotice_NotFound);

            return new PNoticeExportResponse()
            {
                PNotice = new PNoticeExportContract() { Pdf = PunishmentOrgConstants.PNotice.PNoticePrint.ExportPdf("PNotice", pNotice) },
                Result = AnuResult.Successful.GetResult()
            };
        }
        #endregion Overrides

        #region Methods

        #endregion Methods
    }
}