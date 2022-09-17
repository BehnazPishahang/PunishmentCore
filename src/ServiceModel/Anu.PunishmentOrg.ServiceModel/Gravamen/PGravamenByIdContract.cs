
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("ورودی شکوائیه با شناسه واحد")]
    public class PGravamenByIdContract
    {
        public PGravamenByIdContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شناسه واحد")]
        public string? Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره پيگيري")]
        public string? FollowUpNo { get; set; }

    }
}
