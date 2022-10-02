
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("دريافت وجه از شخص در سرویس")]
    public class PCashContract
    {
        public PCashContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نشاني پرداخت کننده وجه")]
        public string? Address { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره کارت")]
        public string? CardNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده ها/فرعي هاي مربوطه")]
        public string? CasesNoSubno { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ چک/فيش/ارجاع مربوطه")]
        public string? CheckFicheDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره چک/فيش/ارجاع مربوطه")]
        public string? CheckFicheNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي پرداخت کننده وجه")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر پرداخت کننده وجه")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن همراه پرداخت کننده وجه")]
        public string? MobilNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پرداخت کننده وجه")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي پرداخت کننده وجه")]
        public string? NationalCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع شخص پرداخت کننده وجه")]
        public Anu.PunishmentOrg.Enumerations.PUAccountPersonType? PaidPersonType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع شخص حقيقي/حقوقي پرداخت کننده وجه")]
        public Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پذيرنده")]
        public string? ReceiverNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت پرداخت کننده وجه")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            
            
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
