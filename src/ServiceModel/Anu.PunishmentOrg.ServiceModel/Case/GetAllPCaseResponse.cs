using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class GetAllPCaseResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public List<GetAllPCaseContract> GetAllPCaseContract { get; set; }

        public GetAllPCaseResponse()
        {
            Result = new Result();
            GetAllPCaseContract = new List<GetAllPCaseContract>();
        }
    }
}
