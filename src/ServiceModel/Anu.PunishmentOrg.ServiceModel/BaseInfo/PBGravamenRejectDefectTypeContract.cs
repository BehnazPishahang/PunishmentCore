
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("نوع علت رد/نقض شکوائيه در سرویس")]
    public class PBGravamenRejectDefectTypeContract
    {
        public PBGravamenRejectDefectTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("علت رد يا نقص؟")]
        public Anu.PunishmentOrg.Enumerations.RejectOrDefect? RejectOrDefect { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
