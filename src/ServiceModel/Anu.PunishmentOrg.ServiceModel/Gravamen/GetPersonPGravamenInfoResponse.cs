
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("GetPersonPGravamenInfoResponse")]
    public class GetPersonPGravamenInfoResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public Page<List<PGravamenInfoContract>> PNotice { get; set; }

        public GetPersonPGravamenInfoResponse()
        {
            Result = new Result();
            PNotice = new Page<List<PGravamenInfoContract>>();
        }

    }
}
