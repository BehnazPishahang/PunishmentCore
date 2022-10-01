
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("ارز/کالاهاي، درخواست 4گانه در سرویس")]
    public class PChaseLicenseReqProductFoundContract
    {
        public PChaseLicenseReqProductFoundContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نام تجاري(برند)")]
        public string? BrandName { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع کالاي قاچاق بلحاظ قانوني")]
        public Anu.PunishmentOrg.Enumerations.ContrabandProductType? ContrabandProductType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد کالا/تعداد قطعات ارز")]
        public decimal? Count { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد قطعات ارز")]
        public string? CurrencyUnit { get; set; }

            
            
            [System.ComponentModel.DisplayName("ميزان ارز")]
        public long? CurrencyValue { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ارزش تخميني")]
        public decimal? EstimatedValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه عمومي کالا")]
        public string? GeneralProductID { get; set; }

            
            
            [System.ComponentModel.DisplayName("سالم بودن")]
        public Anu.PunishmentOrg.Enumerations.HealthStatus? HealthStatus { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه کالا")]
        public string? IDNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا کالا فساد پذیر است")]
        public Anu.BaseInfo.Enumerations.YesNo? IsPerishable { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد کالا در دستگاه کاشف")]
        public string? LogisticId { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
        public string? OtherInfo { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعیت بسته بندی")]
        public Anu.PunishmentOrg.Enumerations.PackingStatus? PackingStatus { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کالا/ارز کشف شده")]
        public Anu.PunishmentOrg.Enumerations.PProductOrCurrency? ProductOrCurrency { get; set; }

            
            
            [System.ComponentModel.DisplayName("نو بودن")]
        public Anu.PunishmentOrg.Enumerations.QualityStatus? QualityStatus { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("سريال")]
        public string? SerialNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("قاچاق")]
        public Anu.PunishmentOrg.Enumerations.SmugglingStatus? SmugglingStatus { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کالا/ نوع ارز")]
        public string? SubjectTitle { get; set; }

            

    }
    }
