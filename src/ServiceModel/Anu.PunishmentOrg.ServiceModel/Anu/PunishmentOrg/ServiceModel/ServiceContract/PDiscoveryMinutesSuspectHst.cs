
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("سوابق مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesSuspectHst
    {
        public PDiscoveryMinutesSuspectHst()
        {
        }
            
            [System.ComponentModel.DisplayName("توضيحات")]
            public string Description { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ صورتجلسه")]
            public string DocDate { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره مدرک/سند")]
            public string DocNo { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public PDiscoveryMinutesSuspect ThePDiscoveryMinutesSuspect { get; set ;} 
            

    }
    }
