
using Anu.Commons.ServiceModel.ServicePaging;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("GetPersonPGravamenInfoRequest")]
    public class GetPersonPGravamenInfoRequest : IPaging
    {
        public GetPersonPGravamenInfoContract TheGetPersonPGravamenInfoContract { get; set; }
        public Page Page { get; set; }

        public GetPersonPGravamenInfoRequest()
        {
            TheGetPersonPGravamenInfoContract = new GetPersonPGravamenInfoContract();
            Page = new Page();
        }

    }
}
