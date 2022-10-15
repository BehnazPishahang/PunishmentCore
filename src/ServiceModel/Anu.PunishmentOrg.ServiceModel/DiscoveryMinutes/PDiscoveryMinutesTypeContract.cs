
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("نوع محل و مکان محل کشف صورتجلسه/گزارش کشف قاچاق/اسنادي در سرویس")]
    public class PDiscoveryMinutesTypeContract
    {
        public PDiscoveryMinutesTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع محل و مکان محل کشف")]
        public Anu.PunishmentOrg.Enumerations.PBDiscoveryMinutesType? PBDiscoveryMinuteType { get; set; }

            

    }
    }
