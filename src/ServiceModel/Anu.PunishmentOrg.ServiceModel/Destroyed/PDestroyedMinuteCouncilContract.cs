
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("اعضاء شوراي تشخيص اسناد سازمان امضاء کننده صورتجلسه-فرم 3 در سرویس")]
    public class PDestroyedMinuteCouncilContract
    {
        public PDestroyedMinuteCouncilContract()
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
        public Anu.PunishmentOrg.Enumerations.DestroyedMinuteCouncil? PresentPost { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جنسيت عضو")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            

    }
    }
