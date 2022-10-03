
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("واحدهاي صنفي بازرسي شده در گشت سيار در سرویس")]
    public class PMobilePatrolsTradeUnitContract
    {
        public PMobilePatrolsTradeUnitContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نشاني")]
        public string? Address { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ تولد")]
        public string? BirthDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره فرم چهاربرگی")]
        public string? FourPagedFormNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره گزارش بازرسي")]
        public string? InspectionNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("دستگاه اصلی")]
        public Anu.PunishmentOrg.Enumerations.PBMajorUnits? MajorUnit { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن همراه")]
        public string? MobilNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي")]
        public string? NationalCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساعت مراجعه به واحد صنفي")]
        public string? ReferenceTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نتيجه")]
        public Anu.PunishmentOrg.Enumerations.PUMobilePatrolsResult? Result { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ صدور پروانه/مجوز کسب واحد صنفي")]
        public string? TradeLicenseDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پروانه/مجوز کسب واحد صنفي")]
        public string? TradeLicenseNumber { get; set; }

            

    }
    }
