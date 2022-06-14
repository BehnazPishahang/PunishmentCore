using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PunishmentOrg.Domain.Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes;
using PunishmentOrg.Domain.Interface;

namespace PunishmentOrg.Api.Core.Controllers.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDiscoveryMinutesController : ControllerBase
    {

        private readonly ILogger<PDiscoveryMinutes> _logger;
        private readonly IUnitOfWork _unitOfWork;

        
        public PDiscoveryMinutesController(ILogger<PDiscoveryMinutes> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "PDiscoveryMinutes/{UniqueNo}")]
        public async Task<string> PDiscoveryMinutesAsync(string UniqueNo)
        {
            var pDiscovery = await _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(UniqueNo);
            string title = pDiscovery.FirstOrDefault().TheObjectState.Title.ToString();

            _unitOfWork.Complete();


            return title;
        }

    }
}
