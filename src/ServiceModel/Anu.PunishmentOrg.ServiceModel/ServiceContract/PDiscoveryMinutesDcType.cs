
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("انواع کشف صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesDcType
    {
        public PDiscoveryMinutesDcType()
        {
        }
            
            
            [System.ComponentModel.DisplayName("نوع کشف")]
            public Anu.PunishmentOrg.Enumerations.PDiscoveryType DiscoveryType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            

    }
    }
