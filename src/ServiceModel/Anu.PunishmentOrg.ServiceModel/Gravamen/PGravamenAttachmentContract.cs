
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    //! کل من علیها fun
    [System.ComponentModel.DisplayName("پیوست شکوائیه/گزارش مردمی در سرویس")]
    public class PGravamenAttachmentContract
    {
        public PGravamenAttachmentContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenContract? ThePGravamenContract { get; set; }

            

    }
    }
