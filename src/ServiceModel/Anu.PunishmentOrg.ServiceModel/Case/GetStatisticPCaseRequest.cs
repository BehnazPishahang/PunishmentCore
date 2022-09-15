using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class GetStatisticPCaseRequest : IRequestMessage
    {
        public Request Request { get; set; }
        public GetStatisticPCaseInputContract GetStatisticPCaseInputContract { get; set; }

        public GetStatisticPCaseRequest()
        {
            Request = new Request();
            GetStatisticPCaseInputContract = new GetStatisticPCaseInputContract();
        }

    }
}
