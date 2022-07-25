
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    public class PDiscoveryMinutesReceiveFromOtherOrgNewReqMsg
    {
            
            
            [System.ComponentModel.DisplayName("زمان ثبت")]
            public string? CreateDateTime { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("تاريخ کشف")]
            public string? DiscoveryDate { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره صورتجلسه ")]
            public string? DiscoveryNO { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("آدرس محل کشف")]
            public string? DiscoveryPlaceAddress { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک محل کشف")]
            public string? DiscoveryPlacePlaque { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شناسه يکتا")]
            public string? UniqueNo { get; set ;} 
            

    }
    }
