
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("پرداخت وجه به شخص در سرویس")]
    public class PPaidContract
    {
        public PPaidContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نشاني دريافت کننده وجه")]
        public string? Address { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ چک/فيش/ارجاع مربوطه")]
        public string? CheckFicheDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره چک/فيش/ارجاع مربوطه")]
        public string? CheckFicheNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي دريافت کننده وجه")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر دريافت کننده وجه")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن همراه دريافت کننده وجه")]
        public string? MobilNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام دريافت کننده وجه")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي دريافت کننده وجه")]
        public string? NationalCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص دريافت کننده وجه")]
        public Anu.PunishmentOrg.Enumerations.PUAccountPersonType? PaidPersonType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص حقيقي/حقوقي دريافت کننده وجه")]
        public Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت دريافت کننده وجه")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            
            
            [System.ComponentModel.DisplayName("هامش")]
        public string? SideNote { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جمع مبلغ پرداختي")]
        public long? TotalPaidCost { get; set; }

            

    }
    }
