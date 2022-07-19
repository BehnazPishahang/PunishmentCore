using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.ServiceBase
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class PInspectionReportBase : ControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;


        public PInspectionReportBase(Anu.DataAccess.IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        [HttpPost("SendPDiscoveryMinutesState")]
        public abstract Task<Anu.PunishmentOrg.ServiceModel.ServiceResponse.SendPInspectionReportStateResponse> SendPInspectionReportState([FromBody] Anu.PunishmentOrg.ServiceModel.ServiceRequest.SendPInspectionReportStateRequest request);

    }
}
