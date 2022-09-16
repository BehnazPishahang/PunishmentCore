using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("ورود سرویس دریافت اطلاعات شکواییه بر اساس آیدی یا شماره پیگیری")]
    public class GetPGravamenByIdRequest
    {
        public GetPGravamenByIdRequest()
        {
            ThePGravamenByIdContract = new Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenByIdContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آیدی شکوائیه/گزارش مردمی در سرویس")]
        public PGravamenByIdContract? ThePGravamenByIdContract { get; set; }
    }
}