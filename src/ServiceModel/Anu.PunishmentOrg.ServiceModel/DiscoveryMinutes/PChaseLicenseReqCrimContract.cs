
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("تخلفات درخواست های 4گانه در سرویس")]
    public class PChaseLicenseReqCrimContract
    {
        public PChaseLicenseReqCrimContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اتهام")]
        public Anu.BaseInfo.Enumerations.Crimes? Crimes { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان اتهامی")]
        public string? CrimesTitle { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتیب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست 4گانه(مجوز بازرسی-تکمیل تحقیقات-اعلام تخلف-تایید مجوز شفاهی) و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            

    }
    }
