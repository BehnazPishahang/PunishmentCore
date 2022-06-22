
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("سمت مظنونين در سرويس")]
    public class PDiscoveryMinutesSuspectPost
    {
        public PDiscoveryMinutesSuspectPost()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت شخص")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PSuspectPostType PostType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspect ThePDiscoveryMinutesSuspect { get; set ;} 
            

    }
    }
