
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("ورود سرویس دریافت اطلاعات شکواییه")]
    public class GetPGravamenInfoRequest
    {
        public GetPGravamenInfoRequest()
        {
            TheGetPGravamenInfoContract = new Anu.PunishmentOrg.ServiceModel.Gravamen.GetPGravamenInfoContract();
        }

        [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.GetPGravamenInfoContract? TheGetPGravamenInfoContract { get; set; }



    }
}
