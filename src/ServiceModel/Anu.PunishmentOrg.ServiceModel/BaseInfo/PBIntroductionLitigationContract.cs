
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("نوع علت طرح در سرویس")]
    public class PBIntroductionLitigationContract
    {
        public PBIntroductionLitigationContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
            [System.ComponentModel.DisplayName("موضوع درخواست رسيدگي مجدد متناظر")]
        public Anu.PunishmentOrg.Enumerations.PURevisionRequestSubject? RequestSubject { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.PunishmentOrg.Enumerations.PULegalPersonState? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کدهاي انواع واحدهاي داراي دسترسي")]
        public string? UnitTypeAccess { get; set; }

            

    }
    }
