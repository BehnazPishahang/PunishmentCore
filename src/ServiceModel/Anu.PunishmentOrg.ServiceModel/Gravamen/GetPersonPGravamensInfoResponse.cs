
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("GetPersonPGravamensInfoResponse")]
    public class GetPersonPGravamensInfoResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public Page<List<PGravamenInfoContract>> ThePGravamenInfoContractList { get; set; }

        public GetPersonPGravamensInfoResponse()
        {
            Result = new Result();
            ThePGravamenInfoContractList = new Page<List<PGravamenInfoContract>>();
        }

    }
}
