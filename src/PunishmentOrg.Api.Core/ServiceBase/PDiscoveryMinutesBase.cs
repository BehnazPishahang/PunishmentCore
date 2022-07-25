using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.ServiceBase
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class PDiscoveryMinutesBase : ControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;


        public PDiscoveryMinutesBase(Anu.DataAccess.IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "PDiscovery/{No}")]
        public abstract Task<Commons.ServiceModel.ServiceResponse.Result> PDiscovery(string No);

        [HttpPost("SendPDiscoveryMinutesState")]
        public abstract Task<Anu.PunishmentOrg.ServiceModel.ServiceResponse.SendPDiscoveryMinutesStateResponse> SendPDiscoveryMinutesState([FromBody] Anu.PunishmentOrg.ServiceModel.ServiceRequest.SendPDiscoveryMinutesStateRequest request);

    }
}
