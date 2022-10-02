
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("قبض جهت پرداخت وجه در سرویس")]
    public class PBill4PaidContract
    {
        public PBill4PaidContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع قبض")]
        public Anu.PunishmentOrg.Enumerations.Bill4PaidType? Billtype { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره کارت")]
        public string? CardNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده ها/فرعي هاي مربوطه")]
        public string? CasesNoSubno { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره چک/فيش/ارجاع مربوطه")]
        public string? CheckFicheNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا پس از دريافت وجه الکترونيکي پرونده بسته شود")]
        public Anu.BaseInfo.Enumerations.YesNo? CloseCaseOrNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه پرداخت")]
        public string? FishNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پذيرنده")]
        public string? ReceiverNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("هامش")]
        public string? SideNote { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پايانه")]
        public string? TerminalID { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جمع مبلغ دريافتي")]
        public long? TotalPaidCost { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان تراکنش از تاريخ تا ميلي ثانيه")]
        public string? TransactionDateTimeSecond { get; set; }

            
            
            [System.ComponentModel.DisplayName("رسيد تراکنش")]
        public string? TransactionReceipt { get; set; }

            

    }
    }
