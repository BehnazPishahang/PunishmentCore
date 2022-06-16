
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع دسترسي کاربر خارج از سازمان در وب سرويس")]
    public class GFESUserAccessType
    {
        public GFESUserAccessType()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
            public string Code { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.Enumerations.State State { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
            public string Title { get; set ;} 
            

    }
    }
