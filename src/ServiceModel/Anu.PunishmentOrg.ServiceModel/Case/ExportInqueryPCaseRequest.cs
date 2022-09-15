using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class ExportInqueryPCaseRequest : IRequestMessage
    {
        public Request Request { get; set; }
        public ExportInqueryPCaseInputContract ExportInqueryPCaseInputContract { get; set; }

        public ExportInqueryPCaseRequest()
        {
            Request = new Request();
            ExportInqueryPCaseInputContract = new ExportInqueryPCaseInputContract();
        }
    }
}
