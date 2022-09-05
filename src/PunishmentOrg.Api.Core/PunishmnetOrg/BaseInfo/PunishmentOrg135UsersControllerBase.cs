using Anu.PunishmentOrg.ServiceModel.BaseInfo;
using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.Api.PunishmnetOrg.BaseInfo
{
    public abstract class PunishmentOrg135UsersControllerBase : ControllerBase
    {
        public PunishmentOrg135UsersControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PunishmentOrg135UsersResponse> GetProfile([Microsoft.AspNetCore.Mvc.FromBody] PunishmentOrg135UsersRequest request);
    }
}
