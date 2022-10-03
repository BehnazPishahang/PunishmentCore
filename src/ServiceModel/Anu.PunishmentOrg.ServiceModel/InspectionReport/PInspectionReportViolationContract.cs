
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("کالاي مربوط به تخلف گزارش بازرسي در سرویس")]
    public class PInspectionReportViolationContract
    {
        public PInspectionReportViolationContract()
        {
        }
            
            [System.ComponentModel.DisplayName("مقدار/تعداد/درصد")]
        public decimal? AmountNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("قيمت مصوب/ارشادي/متعارف")]
        public long? ApprovedFairGuidancePrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه عمومي کالا")]
        public string? GoodCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه کالا")]
        public string? GoodsIdentity { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کالا/خدمات")]
        public string? GoodsServicesName { get; set; }

            
            
            [System.ComponentModel.DisplayName("ميزان موجودي")]
        public long? Inventory { get; set; }

            
            
            [System.ComponentModel.DisplayName("ميزان ريالي تخلف")]
        public long? MonetaryAbuse { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساير نوع تخلف")]
        public string? PBInspectionVioTypOther { get; set; }

            
            
            [System.ComponentModel.DisplayName("درصد سود مجاز")]
        public decimal? PercentAuthorized { get; set; }

            
            
            [System.ComponentModel.DisplayName("قيمت خريد")]
        public long? PurchasePrice { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("قيمت فروش")]
        public long? SalesPrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش کل کالا")]
        public long? TotalValueGoods { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضيحات")]
        public string? ViolationDesc { get; set; }

            

    }
    }
