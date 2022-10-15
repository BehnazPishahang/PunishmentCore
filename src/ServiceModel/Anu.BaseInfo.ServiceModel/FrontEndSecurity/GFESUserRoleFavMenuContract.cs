
namespace Anu.BaseInfo.ServiceModel.FrontEndSecurity
{
    [System.ComponentModel.DisplayName("منوي برون سازماني برگزيده کاربر برون سازماني داراي سمت در سرویس")]
    public class GFESUserRoleFavMenuContract
    {
        public GFESUserRoleFavMenuContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ترتيب")]
        public long? OrderNo { get; set; }

            

    }
    }
