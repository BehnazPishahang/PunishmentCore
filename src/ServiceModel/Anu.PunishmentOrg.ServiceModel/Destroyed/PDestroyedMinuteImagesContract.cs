
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("تصوير صورتجلسه تصميمات کميته اجرايي-فرم 3 در سرویس")]
    public class PDestroyedMinuteImagesContract
    {
        public PDestroyedMinuteImagesContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تصوير صورتجلسه")]
        public byte[]? DocImage { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            

    }
    }
