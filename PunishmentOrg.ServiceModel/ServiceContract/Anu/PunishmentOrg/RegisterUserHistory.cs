
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("سابقه کاربر در وب سرويس")]
    public class RegisterUserHistory
    {
        public RegisterUserHistory()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("از تاريخ و ساعت")]
            public string FromDateTime { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("متن امضاي كاربر")]
            public string SignText { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تا تاريخ و ساعت")]
            public string ToDateTime { get; set ;} 
            

    }
    }
