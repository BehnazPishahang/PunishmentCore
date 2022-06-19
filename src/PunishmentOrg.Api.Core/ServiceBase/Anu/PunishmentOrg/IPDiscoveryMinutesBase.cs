using Microsoft.AspNetCore.Mvc;
using PunishmentOrg.Domain.Interface;

namespace PunishmentOrg.Api.Core.ServiceBase.Anu.PunishmentOrg
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class IPDiscoveryMinutesBase : ControllerBase
    {
        protected readonly IUnitOfWork _unitOfWork;


        public IPDiscoveryMinutesBase(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "PDiscovery/{No}")]
        public abstract Task<ServiceModel.Commons.ServiceResponse.Result> PDiscovery(string No);

        [HttpPost("SendPDiscoveryMinutesState")]
        public abstract ServiceResponse.Anu.PunishmentOrg.SendPDiscoveryMinutesStateResponse SendPDiscoveryMinutesState([FromBody] ServiceRequest.Anu.PunishmentOrg.SendPDiscoveryMinutesStateRequest request);

    }
}
