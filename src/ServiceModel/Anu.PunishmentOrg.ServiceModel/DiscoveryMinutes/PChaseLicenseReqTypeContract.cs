
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("موضوع درخواست، درخواست های 4گانه در سرویس")]
    public class PChaseLicenseReqTypeContract
    {
        public PChaseLicenseReqTypeContract()
        {
        }
            
            [System.ComponentModel.DisplayName("حساب بانکی")]
        public string? BankAccountInformationAPI { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام بانک مقصد")]
        public string? BankAccountName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره حسابت مقصد")]
        public string? BankAccountNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع مجوز تعقيب/بازرسي")]
        public Anu.PunishmentOrg.Enumerations.PUChaseLicenseType? ChaseLicenseType { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره چک")]
        public string? ChequeNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح")]
        public string? Description { get; set; }

            
            
            [System.ComponentModel.DisplayName("مدت کنترل")]
        public string? DurationOfControl { get; set; }

            
            
            [System.ComponentModel.DisplayName("محل حضور")]
        public string? Location { get; set; }

            
            
            [System.ComponentModel.DisplayName("تعداد دفعات کنترل")]
        public string? NumberOfControl { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام حوزه ثبتی")]
        public string? RegistryDomainName { get; set; }

            
            
            [System.ComponentModel.DisplayName("مشخصات پلاک ثبتی")]
        public string? RegistryPlaqeInfo { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعیت پلاک ثبتی")]
        public string? RegistryPlaqeStatus { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("موضوع درخواست")]
        public long? SubjectId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست 4گانه(مجوز بازرسی-تکمیل تحقیقات-اعلام تخلف-تایید مجوز شفاهی) و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان درخواست")]
        public long? TitleId { get; set; }

            

    }
    }
