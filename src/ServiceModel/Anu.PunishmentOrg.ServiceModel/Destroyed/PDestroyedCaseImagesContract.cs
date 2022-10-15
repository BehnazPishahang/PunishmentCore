
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("تصوير اوراق پرونده امحاء در سرویس")]
    public class PDestroyedCaseImagesContract
    {
        public PDestroyedCaseImagesContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تصوير مدرک پرونده")]
        public byte[]? DocImage { get; set; }

            

    }
    }
