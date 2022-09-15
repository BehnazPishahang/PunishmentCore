using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    [System.ComponentModel.DisplayName("ورود سرویس دریافت اطلاعات شکواییه بر اساس آیدی یا شماره پیگیری")]
    public class GetPGravamenByIdRequest
    {
        public PGravamenByIdContract ThePGravamenByIdContract { get; set; }
    }
}