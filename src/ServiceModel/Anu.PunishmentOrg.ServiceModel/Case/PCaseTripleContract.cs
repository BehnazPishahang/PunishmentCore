
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("سه گانه پرونده تعزيرات در سرویس")]
    public class PCaseTripleContract
    {
        public PCaseTripleContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شيوه ارتکاب تخلف")]
        public Anu.PunishmentOrg.Enumerations.OffenderInvolvedType? OffenderInvolvedType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه سه گانه مبدا")]
        public string? SourceObjectId { get; set; }

            

    }
    }
