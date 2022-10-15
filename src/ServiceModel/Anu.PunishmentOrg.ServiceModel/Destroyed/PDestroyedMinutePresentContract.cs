
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("اعضاء حاضر در جلسه-فرم 3 در سرویس")]
    public class PDestroyedMinutePresentContract
    {
        public PDestroyedMinutePresentContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام خانوادگي عضو")]
        public string? Family { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام عضو")]
        public string? Name { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت عضو")]
        public Anu.PunishmentOrg.Enumerations.DestroyedMinutePresent? PresentPost { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جنسيت عضو")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            

    }
    }
