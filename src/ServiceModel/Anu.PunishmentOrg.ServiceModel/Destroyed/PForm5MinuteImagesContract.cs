
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("تصاوير فرم 5 و 6 و 7 در سرویس")]
    public class PForm5MinuteImagesContract
    {
        public PForm5MinuteImagesContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تصوير فرم")]
        public byte[]? DocImage { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرم مربوط به تصوير")]
        public Anu.PunishmentOrg.Enumerations.Form5Images? ImageType { get; set; }

            

    }
    }
