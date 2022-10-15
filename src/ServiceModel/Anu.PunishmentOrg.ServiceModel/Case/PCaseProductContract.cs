
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("کالا/ارز/خدمات مربوط به پرونده تعزيرات در سرویس")]
    public class PCaseProductContract
    {
        public PCaseProductContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تعداد/مقدار کالا/ارز تحويل گرفته شده توسط سازمان تحويل گيرنده")]
        public decimal? BillStoreProductValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام تجاري(برند)")]
        public string? BrandName { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع کالاي قاچاق بلحاظ قانوني")]
        public Anu.PunishmentOrg.Enumerations.ContrabandProductType? ContrabandProductType { get; set; }

            
            
            [System.ComponentModel.DisplayName("کشور سازنده")]
        public string? CountryCreate { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد قطعات ارز")]
        public string? CurrencyUnit { get; set; }

            
            
            [System.ComponentModel.DisplayName("ميزان ارز")]
        public long? CurrencyValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش تخميني توسط کاشف/بازرس")]
        public decimal? EstimatedValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه عمومي کالا")]
        public string? GeneralProductID { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
        public string? OtherInfo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کالا/ارز/خدمات")]
        public Anu.PunishmentOrg.Enumerations.PUProductCurrency? ProductCurrency { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه کالا")]
        public string? ProductID { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع کالاي کشف شده بلحاظ جنس کلي کالا")]
        public Anu.PunishmentOrg.Enumerations.PProductType? ProductType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد/مقدار کالا/ارز از نظر دادگاه")]
        public decimal? ProductValue { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("قيمت فروش")]
        public long? SalePrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("سريال")]
        public string? SerialNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد/شناسه کالا/ارز/خدمات مبدا")]
        public string? SourceObjectId { get; set; }

            
            
            [System.ComponentModel.DisplayName("تعداد/مقدار کالا/ارز در صورتجلسه کشف/گزارش بازرسي")]
        public decimal? SourceProductValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ترتيب کالا/ارز در صورتجلسه کشف/گزارش بازرسي")]
        public long? SourceRowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("قيمت کارشناسي/مصوب")]
        public long? StandardPrice { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کالا/ارز/خدمات")]
        public string? SubjectTitle { get; set; }

            

    }
    }
