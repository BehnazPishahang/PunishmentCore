using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PunishmentOrg.Domain.Interface;

namespace PunishmentOrg.Api.Core.Controllers.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDiscoveryMinutesController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        
        public PDiscoveryMinutesController(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "PDiscoveryMinutes/{UniqueNo}")]
        public async Task<string> PDiscoveryMinutesAsync(string UniqueNo)
        {
            await Task.Delay(1);
            //var pDiscovery = await _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(UniqueNo);
            //string title = pDiscovery.FirstOrDefault().TheObjectState.Title.ToString();

            var byParentCode = _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(UniqueNo);

            _unitOfWork.Complete();


            return "";
        }

    }
}
