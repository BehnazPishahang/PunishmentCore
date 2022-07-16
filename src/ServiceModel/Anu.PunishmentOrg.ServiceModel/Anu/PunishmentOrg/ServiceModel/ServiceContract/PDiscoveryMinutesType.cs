
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع محل و مکان محل کشف صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesType
    {
        public PDiscoveryMinutesType()
        {
        }
            
            
            [System.ComponentModel.DisplayName("نوع محل و مکان محل کشف")]
            public Anu.PunishmentOrg.Enumerations.PBDiscoveryMinutesType PBDiscoveryMinuteType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            

    }
    }
