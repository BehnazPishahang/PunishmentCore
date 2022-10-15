
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("اتهامات مظنونين صورتجلسه/گزارش کشف قاچاق/اسنادي در سرویس")]
    public class PDiscoveryMinutesSuspectVioContract
    {
        public PDiscoveryMinutesSuspectVioContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شيوه ارتکاب تخلف")]
        public Anu.PunishmentOrg.Enumerations.OffenderInvolvedType? OffenderInvolvedType { get; set; }

            

    }
    }
