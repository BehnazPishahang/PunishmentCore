
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("مشخصات اوراق امحايي داراي مجوز در فرم 4 در سرویس")]
    public class PDestroyedLicensePagesContract
    {
        public PDestroyedLicensePagesContract()
        {
        }
            
            [System.ComponentModel.DisplayName("از تاريخ")]
        public string? FromDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه مجوز")]
        public string? LicenseID { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد بر حسب برگ")]
        public long? NumPages { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان اوراق داراي مجوز")]
        public string? PagesTitle { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("تا تاريخ")]
        public string? ToDate { get; set; }

            

    }
    }
