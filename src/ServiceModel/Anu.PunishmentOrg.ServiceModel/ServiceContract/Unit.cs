
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("واحد ثبتي در سرويس")]
    public class Unit
    {
        public Unit()
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
