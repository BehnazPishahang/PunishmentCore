
namespace Anu.BaseInfo.ServiceModel.FrontEndSecurity
{
    [System.ComponentModel.DisplayName("تاريخچه تغيير وضعيت فرم ها توسط کاربر خارج از سازماني در سرویس")]
    public class GFESChangeStateHstContract
    {
        public GFESChangeStateHstContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان تغيير وضعيت")]
        public string? ChangeDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ثانيه تغيير")]
        public long? ChangeSecond { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه مدرک مکانيزه مربوطه")]
        public string? RelatedObjectId { get; set; }

            

    }
    }
