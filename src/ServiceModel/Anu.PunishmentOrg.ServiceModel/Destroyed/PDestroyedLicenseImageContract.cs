
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("تصوير فهرست اوراق داراي مجوز امحاء-فرم 4 در سرویس")]
    public class PDestroyedLicenseImageContract
    {
        public PDestroyedLicenseImageContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تصوير فرم")]
        public byte[]? DocImage { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            

    }
    }
