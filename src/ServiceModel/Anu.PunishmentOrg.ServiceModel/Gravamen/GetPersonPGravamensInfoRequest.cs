
using Anu.Commons.ServiceModel.ServicePaging;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("GetPersonPGravamensInfoRequest")]
    public class GetPersonPGravamensInfoRequest : IPaging
    {
        public GetPersonPGravamenInfoContract TheGetPersonPGravamenInfoContract { get; set; }
        public Page Page { get; set; }

        public GetPersonPGravamensInfoRequest()
        {
            TheGetPersonPGravamenInfoContract = new GetPersonPGravamenInfoContract();
            Page = new Page();
        }

    }
}
