
using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    public abstract class PGravamenServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
    public PGravamenServiceControllerBase()
    {
    }
        [Microsoft.AspNetCore.Mvc.HttpPost]
            [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PGravamenServiceResponse> RecieveGravamen([Microsoft.AspNetCore.Mvc.FromBody]PGravamenServiceRequest request);

    }
    }
