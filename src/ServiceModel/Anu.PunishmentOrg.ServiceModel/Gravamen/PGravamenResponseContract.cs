

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("خروجی سفارشی شکوائیه")]
    public class PGravamenResponseContract
    {
        public PGravamenResponseContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره پيگيري")]
        public string? FollowUpNo { get; set; }



    }
}
