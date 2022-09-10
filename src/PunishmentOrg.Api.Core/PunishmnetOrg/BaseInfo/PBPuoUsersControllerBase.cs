using Anu.PunishmentOrg.ServiceModel.BaseInfo;
using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.Api.PunishmnetOrg.BaseInfo
{
    public abstract class PBPuoUsersControllerBase : ControllerBase
    {
        public PBPuoUsersControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PBPuoUsersResponse> GetProfile([Microsoft.AspNetCore.Mvc.FromBody] PBPuoUsersRequest request);
    }
}
