
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("ورودي پرونده تعزيرات در سرویس")]
    public class PCaseInputContract
    {
        public PCaseInputContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان خاتمه")]
        public string? EndDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ نامه بازرسي")]
        public string? InspectionDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره نامه بازرسي")]
        public string? InspectionNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ بازرسي/شکايت")]
        public string? OuterCaseDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره گزارش بازرسي/شکايت")]
        public string? OuterCaseNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع مرجع ارسال کننده گزارش بازرسي/شکايت")]
        public Anu.PunishmentOrg.Enumerations.PUSenderCaseType? SenderUnitType { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره بايگاني پرونده در مبدا")]
        public string? SourceCaseArchiveNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده در مبدا")]
        public string? SourceCaseNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره فرعي پرونده در مبدا")]
        public long? SourceCaseSubNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ورود")]
        public string? StartDateTime { get; set; }

            

    }
    }
