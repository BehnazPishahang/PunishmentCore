
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    //! کل من علیها fun
    [System.ComponentModel.DisplayName("ورودی سرویس شکوائیه")]
    public class PGravamenServiceRequest
    {
        public PGravamenServiceRequest()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenContract? ThePGravamenContract { get; set; }

            

    }
    }
