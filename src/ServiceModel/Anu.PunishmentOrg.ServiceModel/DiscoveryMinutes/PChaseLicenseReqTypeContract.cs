
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("نوع درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
    public class PChaseLicenseReqTypeContract
    {
        public PChaseLicenseReqTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مجوز تعقيب/بازرسي")]
        public Anu.PunishmentOrg.Enumerations.PUChaseLicenseType? ChaseLicenseType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName(" رديف")]
        public string? Id { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            

    }
    }
