
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.Notice;

namespace Anu.PunishmentOrg.Api.Notice
{
    public abstract class PNoticeServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public PNoticeServiceControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PNoticeInqueryResponse> InqueryPNoticeList([Microsoft.AspNetCore.Mvc.FromBody] PNoticeInqueryRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PNoticeExportResponse> ExportPNotice([Microsoft.AspNetCore.Mvc.FromBody] PNoticeExportRequest request);

    }
}
