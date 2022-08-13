
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("PDiscoveryMinutesStateResponse")]
    public class PDiscoveryMinutesStateResponse : IResponseMessage
    {
        public PDiscoveryMinutesStateResponse()
        {
            Result = new Result();
            ThePDiscoveryMinutesStateContract= new PDiscoveryMinutesStateContract();    
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آخرين وضعيت صورتجلسه کشف در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PDiscoveryMinutesStateContract? ThePDiscoveryMinutesStateContract { get; set; }
        public Result Result { get; set; }
    }
}
