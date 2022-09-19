
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("GetPersonPGravamenStatisticRequest")]
    public class GetPersonPGravamenStatisticRequest
    {
        public GetPersonPGravamenStatisticRequest()
        {
            TheGetPersonPGravamenInfoContract = new GetPersonPGravamenInfoContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شخص ابلاغ شونده")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.GetPersonPGravamenInfoContract? TheGetPersonPGravamenInfoContract { get; set; }
    }
}
