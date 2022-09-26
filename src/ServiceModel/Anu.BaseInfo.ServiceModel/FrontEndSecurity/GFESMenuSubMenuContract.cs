
namespace Anu.BaseInfo.ServiceModel.FrontEndSecurity
{
    [System.ComponentModel.DisplayName("درختواره منوي برون سازماني در سرویس")]
    public class GFESMenuSubMenuContract
    {
        public GFESMenuSubMenuContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ترتيب")]
        public long? OrderNo { get; set; }

            

    }
    }
