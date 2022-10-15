
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("مرخصي زنداني در سرویس")]
    public class PPrisonerLeaveContract
    {
        public PPrisonerLeaveContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ خاتمه مرخصي")]
        public string? EndDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ شروع مرخصي")]
        public string? StartDate { get; set; }

            

    }
    }
