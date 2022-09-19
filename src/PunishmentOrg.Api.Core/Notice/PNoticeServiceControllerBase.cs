
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
        [Microsoft.AspNetCore.Mvc.Route("api/v1/Notice/InqueryPNoticeList")]
        public abstract Task<PNoticeInqueryResponse> InqueryPNoticeList([Microsoft.AspNetCore.Mvc.FromBody] PNoticeInqueryRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/Notice/ExportPNotice")]
        public abstract Task<ExportPNoticeResponse> ExportPNotice([Microsoft.AspNetCore.Mvc.FromBody] ExportPNoticeRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/Notice/ChangePNoticeViewByUserStatus")]
        public abstract Task<ChangePNoticeViewByUserStatusResponse> ChangePNoticeViewByUserStatus([Microsoft.AspNetCore.Mvc.FromBody] ChangePNoticeViewByUserStatusRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/Notice/GetCountOfUnSeenPNoticeByUser")]
        public abstract Task<GetCountOfUnSeenPNoticeByUserResponse> GetCountOfUnSeenPNoticeByUser([Microsoft.AspNetCore.Mvc.FromBody] GetCountOfUnSeenPNoticeByUserRequest request);

    }
}
