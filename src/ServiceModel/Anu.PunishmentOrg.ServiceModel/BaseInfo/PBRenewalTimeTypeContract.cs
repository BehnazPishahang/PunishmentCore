
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("نوع علت تجديد وقت در سرویس")]
    public class PBRenewalTimeTypeContract
    {
        public PBRenewalTimeTypeContract()
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
