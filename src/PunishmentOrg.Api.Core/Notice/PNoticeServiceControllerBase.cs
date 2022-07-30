
using Anu.PunishmentOrg.ServiceModel.Notice;

namespace Anu.PunishmentOrg.Api.Notice
{
    public abstract class PNoticeServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public PNoticeServiceControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v2/BillStore/InqueryPNoticeList")]
        public abstract PNoticeInqueryResponse InqueryPNoticeList([Microsoft.AspNetCore.Mvc.FromBody] PNoticePersonContract request);

    }
}
