
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("سازمان هاي تعامل کننده در مورد پرونده در سرويس")]
    public class PBExchangeUnit
    {
        public PBExchangeUnit()
        {
        }
            
            
            [System.ComponentModel.DisplayName("کد")]
            public string? LocationCode { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام")]
            public string? LocationName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.BaseInfo.Enumerations.State State { get; set ;} 
            

    }
    }
