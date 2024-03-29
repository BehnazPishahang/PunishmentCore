﻿
namespace Anu.BaseInfo.ServiceModel.SystemConfiguration
{
    [System.ComponentModel.DisplayName("نوع سمت كاربر در سرویس")]
    public class CMSUserRoleTypeContract
    {
        public CMSUserRoleTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا سمت مدير سيستم است")]
        public Anu.BaseInfo.Enumerations.YesNo? IsSystemManager { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع سياست برخورد با اتصال هاي متعدد يک شناسه کاربري با اين نقش بر روي کامپيوترهاي متعدد")]
        public Anu.BaseInfo.Enumerations.MultiSessionPolicy? MultiSessionPolicy { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Name { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا براي ورود به سيستم با اين نقش، استفاده از توکن اجباري است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? TokenRequired { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تبديل به متن")]
        public string? ToStringDefault { get; set; }

            

    }
    }
