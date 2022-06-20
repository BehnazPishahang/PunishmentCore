
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع جرم يا تخلف صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesSmugType
    {
        public PDiscoveryMinutesSmugType()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع جرم يا تخلف")]
            public Anu.Enumerations.PunishmentOrg.PSmuggling SmugglingType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            

    }
    }
