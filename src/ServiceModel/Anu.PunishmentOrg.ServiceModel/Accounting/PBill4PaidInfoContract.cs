
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("وضعیت پرداخت در سرویس")]
    public class PBill4PaidInfoContract
    {
        public PBill4PaidInfoContract()
        {
        }
            
            [System.ComponentModel.DisplayName("آیا می تواند پرداخت انجام دهد؟")]
        public bool? CanPay { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضیحات")]
        public string? Desc { get; set; }

            

    }
    }
