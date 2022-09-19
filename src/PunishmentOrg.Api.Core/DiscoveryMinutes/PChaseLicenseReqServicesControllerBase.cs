
using Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes;
using Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes;

namespace Anu.PunishmentOrg.Api.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqServicesControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public PChaseLicenseReqServicesControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/DiscoveryMinutes/SendPChaseLicenseReqList")]
        public abstract Task<PChaseLicenseReqResponse> SendPChaseLicenseReqList([Microsoft.AspNetCore.Mvc.FromBody] PChaseLicenseReqRequest request);

    }
}
