
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("GetPaymentInfoRequest")]
    public class GetPaymentInfoRequest
    {
        public GetPaymentInfoRequest()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه پرداخت در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidFishNoContract? ThePBill4PaidFishNoContract { get; set; }

            

    }
    }
