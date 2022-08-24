
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("ورودی سرویس شکوائیه")]
    public class PGravamenServiceRequest
    {
        public PGravamenServiceRequest()
        {
            ThePGravamenContract = new Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenContract? ThePGravamenContract { get; set; }



    }
}
