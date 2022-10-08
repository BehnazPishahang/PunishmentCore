
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("نوع موضوع لازم الاجرا در سرویس")]
    public class PBBindingSubjectTypeContract
    {
        public PBBindingSubjectTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا موضوع لازم الاجرا مربوط به کالا/ارز/خدمات است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? Is4GoodsCurrency { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع موضوع")]
        public Anu.PunishmentOrg.Enumerations.PUPenaltyType? PenaltyType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
