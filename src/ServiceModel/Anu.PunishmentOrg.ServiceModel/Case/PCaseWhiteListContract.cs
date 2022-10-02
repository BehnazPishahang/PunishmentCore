
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("ليست سفيد پرونده ها در سرویس")]
    public class PCaseWhiteListContract
    {
        public PCaseWhiteListContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ نامه مستند استثناء")]
        public string? DocLetterDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("تصوير نامه مستند استثناء")]
        public byte[]? DocLetterImage { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره نامه مستند استثناء")]
        public string? DocLetterNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع استثناء")]
        public Anu.PunishmentOrg.Enumerations.ExceptionType? ExceptionType { get; set; }

            

    }
    }
