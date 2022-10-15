
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("سازمان داراي دسترسي به درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
    public class PChaseLicenseReqUnitContract
    {
        public PChaseLicenseReqUnitContract()
        {
        }
            
            [System.ComponentModel.DisplayName("سازمان هاي تعامل کننده در مورد پرونده")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? ThePBExchangeUnit { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست 4گانه(مجوز بازرسی-تکمیل تحقیقات-اعلام تخلف-تایید مجوز شفاهی) و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            

    }
    }
