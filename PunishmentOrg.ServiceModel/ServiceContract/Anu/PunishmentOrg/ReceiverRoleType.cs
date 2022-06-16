
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("سمت گيرنده نامه/رونوشت درون سازماني")]
    public class ReceiverRoleType
    {
        public ReceiverRoleType()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
            public string Code { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا سمت مدير سيستم است")]
            public Anu.Enumerations.YesNo IsSystemManager { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع سياست برخورد با اتصال هاي متعدد يک شناسه کاربري با اين نقش بر روي کامپيوترهاي متعدد")]
            public Anu.Enumerations.MultiSessionPolicy MultiSessionPolicy { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
            public string Name { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.Enumerations.State State { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا براي ورود به سيستم با اين نقش، استفاده از توکن اجباري است؟")]
            public Anu.Enumerations.YesNo TokenRequired { get; set ;} 
            

    }
    }
