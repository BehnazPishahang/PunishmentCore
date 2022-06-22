
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("واحد ثبتي در سرويس")]
    public class Unit
    {
        public Unit()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
            public string LocationCode { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
            public string LocationName { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
            public DataModel.BaseInfo.Anu.Enumerations.State State { get; set ;} 
            

    }
    }
