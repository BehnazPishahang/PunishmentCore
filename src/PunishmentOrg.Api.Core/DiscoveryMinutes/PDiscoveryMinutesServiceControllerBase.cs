
using Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes;
using Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes;

namespace Anu.PunishmentOrg.Api.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public PDiscoveryMinutesServiceControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PDiscoveryMinutesStateResponse> SendPDiscoveryMinutesState([Microsoft.AspNetCore.Mvc.FromBody] PDiscoveryMinutesStateRequest request);

    }
}
