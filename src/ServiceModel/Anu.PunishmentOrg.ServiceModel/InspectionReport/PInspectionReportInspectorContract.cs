
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("بازرسان گزارش بازرسي در سرویس")]
    public class PInspectionReportInspectorContract
    {
        public PInspectionReportInspectorContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد")]
        public string? InspectorCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت")]
        public Anu.PunishmentOrg.Enumerations.PUInspectorPost? InspectorPost { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد ملي")]
        public string? NationalCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام دستگاه")]
        public string? SystemName { get; set; }

            

    }
    }
