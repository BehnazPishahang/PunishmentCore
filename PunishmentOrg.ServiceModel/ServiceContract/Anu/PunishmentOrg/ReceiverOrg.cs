
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("سازمان دروني گيرنده نامه/رونوشت در وب سرويس دريافت مکاتبات")]
    public class ReceiverOrg
    {
        public ReceiverOrg()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آدرس")]
            public string Address { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره")]
            public string CMSOrganizationNo { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
            public string Code { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
            public string Name { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
            public DataModel.BaseInfo.Anu.Enumerations.State State { get; set ;} 
            

    }
    }
