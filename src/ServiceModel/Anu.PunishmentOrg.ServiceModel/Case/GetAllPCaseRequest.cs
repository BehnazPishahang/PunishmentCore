using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class GetAllPCaseRequest : IRequestMessage
    {
        public GetAllPCaseRequest()
        {
            Request = new Request();
            GetAllPCaseInputContract = new GetAllPCaseInputContract();
        }

        public GetAllPCaseInputContract GetAllPCaseInputContract { get; set; }

        public Request Request { get; set; }
    }
}
