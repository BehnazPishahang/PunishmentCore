
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("ارز/کالاهاي مکشوفه صورتجلسه/گزارش کشف قاچاق/اسنادي در سرویس")]
    public class PDiscoveryMinutesProductFoundContract
    {
        public PDiscoveryMinutesProductFoundContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره رسيد/قبض سازمان تحويل گيرنده کالا")]
        public string? BillNoProductFound { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام تجاري(برند)")]
        public string? BrandName { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام تجاري(برند)")]
        public Anu.PunishmentOrg.Enumerations.BrandName? BrandNameRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع کالاي قاچاق بلحاظ قانوني")]
        public Anu.PunishmentOrg.Enumerations.ContrabandProductType? ContrabandProductType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد کالا/تعداد قطعات ارز")]
        public decimal? Count { get; set; }

            
            
            [System.ComponentModel.DisplayName("کشور سازنده")]
        public string? CountryCreate { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن کشور سازنده")]
        public Anu.PunishmentOrg.Enumerations.CountryCreate? CountryCreateRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد قطعات ارز")]
        public string? CurrencyUnit { get; set; }

            
            
            [System.ComponentModel.DisplayName("ميزان ارز")]
        public long? CurrencyValue { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ارزش تخميني")]
        public decimal? EstimatedValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه عمومي کالا")]
        public string? GeneralProductID { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه کالا")]
        public string? IDNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شناسه")]
        public Anu.PunishmentOrg.Enumerations.IDNumber? IDNumberRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
        public string? OtherInfo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کالا/ارز کشف شده")]
        public Anu.PunishmentOrg.Enumerations.PProductOrCurrency? ProductOrCurrency { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع کالاي کشف شده")]
        public Anu.PunishmentOrg.Enumerations.PProductType? ProductType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("سريال")]
        public string? SerialNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن سريال")]
        public Anu.PunishmentOrg.Enumerations.SerialNumber? SerialNumberRN { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کالا/ نوع ارز")]
        public string? SubjectTitle { get; set; }

            

    }
    }
