
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("تاريخچه تراکنش هاي آزمون POS در سرویس")]
    public class PPOSTestLogContract
    {
        public PPOSTestLogContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره کارت")]
        public string? CardNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره چک/فيش/ارجاع مربوطه")]
        public string? CheckFicheNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پذيرنده")]
        public string? ReceiverNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پايانه")]
        public string? TerminalID { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مبلغ دريافتي")]
        public long? TotalPaidCost { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان تراکنش از تاريخ تا ميلي ثانيه")]
        public string? TransactionDateTimeSecond { get; set; }

            
            
            [System.ComponentModel.DisplayName("رسيد تراکنش")]
        public string? TransactionReceipt { get; set; }

            

    }
    }
