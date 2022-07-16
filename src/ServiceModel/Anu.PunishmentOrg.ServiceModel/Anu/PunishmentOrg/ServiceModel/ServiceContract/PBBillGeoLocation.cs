
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("مکان جغرافيايي درسرويس")]
    public class PBBillGeoLocation
    {
        public PBBillGeoLocation()
        {
        }
            
            
            [System.ComponentModel.DisplayName("نام کامل")]
            public string? FullLocationName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("کد")]
            public string? LocationCode { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام")]
            public string? LocationName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع")]
            public Anu.BaseInfo.Enumerations.LocationType LocationType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.BaseInfo.Enumerations.State State { get; set ;} 
            

    }
    }
