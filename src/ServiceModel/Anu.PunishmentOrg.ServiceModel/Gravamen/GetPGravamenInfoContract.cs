
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("ورود سرویس دریافت اطلاعات شکواییه")]
    public class GetPGravamenInfoContract
    {
        public GetPGravamenInfoContract()
        {
        }

        [System.ComponentModel.DisplayName("شماره پيگيري")]
        public string? FollowUpNo { get; set; }



    }
}
