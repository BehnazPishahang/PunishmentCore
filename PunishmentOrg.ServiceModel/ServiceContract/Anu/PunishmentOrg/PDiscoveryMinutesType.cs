
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع محل و مکان محل کشف صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesType
    {
        public PDiscoveryMinutesType()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع محل و مکان محل کشف")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PBDiscoveryMinutesType PBDiscoveryMinuteType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            

    }
    }
