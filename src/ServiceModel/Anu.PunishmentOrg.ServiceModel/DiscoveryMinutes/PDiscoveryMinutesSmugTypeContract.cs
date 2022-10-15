
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("نوع جرم يا تخلف صورتجلسه/گزارش کشف قاچاق/اسنادي در سرویس")]
    public class PDiscoveryMinutesSmugTypeContract
    {
        public PDiscoveryMinutesSmugTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع جرم يا تخلف")]
        public Anu.PunishmentOrg.Enumerations.PSmuggling? SmugglingType { get; set; }

            

    }
    }
