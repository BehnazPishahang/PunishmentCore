
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع جرم يا تخلف صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesSmugType
    {
        public PDiscoveryMinutesSmugType()
        {
        }
            
            
            [System.ComponentModel.DisplayName("نوع جرم يا تخلف")]
            public Anu.PunishmentOrg.Enumerations.PSmuggling SmugglingType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            

    }
    }
