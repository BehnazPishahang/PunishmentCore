
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("انواع کشف صورتجلسه/گزارش کشف قاچاق/اسنادي در سرویس")]
    public class PDiscoveryMinutesDcTypeContract
    {
        public PDiscoveryMinutesDcTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع کشف")]
        public Anu.PunishmentOrg.Enumerations.PDiscoveryType? DiscoveryType { get; set; }

            

    }
    }
