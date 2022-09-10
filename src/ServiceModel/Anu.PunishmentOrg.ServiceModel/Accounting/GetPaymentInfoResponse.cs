
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("GetPaymentInfoResponse")]
    public class GetPaymentInfoResponse
    {
        public GetPaymentInfoResponse()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعیت پرداخت در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidInfoContract? ThePBill4PaidInfoContract { get; set; }

            

    }
    }
