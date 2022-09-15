
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    //! کل من علیها fun
    public abstract class PGravamenServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public PGravamenServiceControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
            [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PGravamenServiceResponse> RecieveGravamen([Microsoft.AspNetCore.Mvc.FromBody]PGravamenServiceRequest request);
        [Microsoft.AspNetCore.Mvc.HttpPost]
            [Microsoft.AspNetCore.Mvc.Route("api/v1/Gravamen/GetPGravamenInfo")]
        public abstract Task<GetPGravamenInfoResponse> GetPGravamenInfo([Microsoft.AspNetCore.Mvc.FromBody]GetPGravamenInfoRequest request);
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/Gravamen/GetPGravamenByFollowUpNo")]
        public abstract Task<GetPGravamenByIdResponse> GetPGravamenById([Microsoft.AspNetCore.Mvc.FromBody] GetPGravamenByIdRequest request);

    }
}
