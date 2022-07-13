using Anu.PunishmentOrg.ServiceModel.ServiceRequest;
using Anu.PunishmentOrg.ServiceModel.ServiceResponse;
using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.ServiceBase
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class IPBillStoreBase : ControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;


        public IPBillStoreBase(Anu.DataAccess.IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        [HttpPost("ReceivePBillStoreFromScms")]
        public abstract Task<ReceivePBillStoreFromScmsResponse> ReceivePBillStoreFromScms([FromBody] ReceivePBillStoreFromScmsRequest request);

    }
}
