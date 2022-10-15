
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("سمت مظنونين در سرویس")]
    public class PDiscoveryMinutesSuspectPostContract
    {
        public PDiscoveryMinutesSuspectPostContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت شخص")]
        public Anu.PunishmentOrg.Enumerations.PSuspectPostType? PostType { get; set; }

            

    }
    }
