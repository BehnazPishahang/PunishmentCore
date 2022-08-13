
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("PDiscoveryMinutesStateRequest")]
    public class PDiscoveryMinutesStateRequest : IRequestMessage
    {
        public PDiscoveryMinutesStateRequest()
        {
            Request = new Request();
            ThePDiscoveryMinutesInputContract = new PDiscoveryMinutesInputContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("ورودی سرویس استعلام وضعیت صورتجلسه کشف در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PDiscoveryMinutesInputContract? ThePDiscoveryMinutesInputContract { get; set; }

        public Request Request { get; set; }

    }
}
