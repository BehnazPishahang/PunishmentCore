
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("GetPersonPGravamenInfoContract")]
    public class GetPersonPGravamenInfoContract
    {

        public GetPersonPGravamenInfoContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کد ملی شخص")]
        public string? NationalityCode { get; set; }

    }
}
