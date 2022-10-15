
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("مشخصات اوراق امحايي فرم 5 در سرویس")]
    public class PForm5MinutePagesContract
    {
        public PForm5MinutePagesContract()
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

            
            
            [System.ComponentModel.DisplayName("تا تاريخ")]
        public string? ToDate { get; set; }

            

    }
    }
