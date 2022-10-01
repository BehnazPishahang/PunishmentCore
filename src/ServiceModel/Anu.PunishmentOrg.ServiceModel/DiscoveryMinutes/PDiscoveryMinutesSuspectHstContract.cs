
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("سوابق مظنونين صورتجلسه/گزارش کشف قاچاق در سرویس")]
    public class PDiscoveryMinutesSuspectHstContract
    {
        public PDiscoveryMinutesSuspectHstContract()
        {
        }
            
            [System.ComponentModel.DisplayName("توضيحات")]
        public string? Description { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ صورتجلسه")]
        public string? DocDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره مدرک/سند")]
        public string? DocNo { get; set; }

            

    }
    }
