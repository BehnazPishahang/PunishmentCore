
namespace Anu.BaseInfo.ServiceModel.FrontEndSecurity
{
    [System.ComponentModel.DisplayName("منوي برون سازماني در سرویس")]
    public class GFESMenuContract
    {
        public GFESMenuContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شرح")]
        public string? Description { get; set; }

            
            
            [System.ComponentModel.DisplayName("فرمان مستقيم")]
        public string? DirectCommand { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.MenuItemState? MenuItemState { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            

    }
    }
