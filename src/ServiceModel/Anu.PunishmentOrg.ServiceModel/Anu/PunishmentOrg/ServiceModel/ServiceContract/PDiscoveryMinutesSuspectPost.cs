
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("سمت مظنونين در سرويس")]
    public class PDiscoveryMinutesSuspectPost
    {
        public PDiscoveryMinutesSuspectPost()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت شخص")]
            public Anu.PunishmentOrg.Enumerations.PSuspectPostType PostType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public PDiscoveryMinutesSuspect ThePDiscoveryMinutesSuspect { get; set ;} 
            

    }
    }
