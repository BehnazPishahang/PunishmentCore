
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("سازمان داراي دسترسي به درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
    public class PChaseLicenseReqUnitContract
    {
        public PChaseLicenseReqUnitContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName(" رديف")]
        public string? Id { get; set; }

            
            
            [System.ComponentModel.DisplayName("سازمان هاي تعامل کننده در مورد پرونده")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? ThePBExchangeUnit { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            

    }
    }
