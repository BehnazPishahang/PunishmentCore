
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("خروجی سرویس دریافت اطلاعات شکواییه")]
    public class GetPGravamenInfoResponse
    {
        public GetPGravamenInfoResponse()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اطلاعات شکوائیه/گزارش در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenInfoContract? ThePGravamenInfoContract { get; set; }

            

    }
    }
