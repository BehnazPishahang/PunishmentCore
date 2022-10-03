
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("شاکي هاي گزارش بازرسي در سرویس")]
    public class PInspectionReportPersonContract
    {
        public PInspectionReportPersonContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نشاني")]
        public string? Address { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ تولد حقيقي/ثبت حقوقي")]
        public string? BirthDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("خسارت وارده شده به شخص")]
        public long? DamageCausedValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه شخص حقيقي/شماره ثبت شخص حقوقي")]
        public string? IdentityNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن همراه")]
        public string? MobilNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي/کدفراگير اتباع خارجي")]
        public string? NationalCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("تابعيت")]
        public Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص")]
        public Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد پستي")]
        public string? PostCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            

    }
    }
