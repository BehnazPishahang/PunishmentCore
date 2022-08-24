
namespace Anu.BaseInfo.ServiceModel.FrontEndSecurity
{
    [System.ComponentModel.DisplayName("نوع دسترسي کاربر خارج از سازمان در سرویس")]
    public class GFESUserAccessTypeContract
    {
        public GFESUserAccessTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
