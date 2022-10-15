
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("اجازه رويت موقت پرونده در سرویس")]
    public class PInterimVisibleCaseContract
    {
        public PInterimVisibleCaseContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ خاتمه مجوز")]
        public string? EndDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ شروع مجوز")]
        public string? StartDate { get; set; }

            

    }
    }
