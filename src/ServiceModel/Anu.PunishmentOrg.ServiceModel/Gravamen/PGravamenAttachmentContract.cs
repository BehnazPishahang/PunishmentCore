
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("پيوست شکوائيه/گزارش مردمي در سرویس")]
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
