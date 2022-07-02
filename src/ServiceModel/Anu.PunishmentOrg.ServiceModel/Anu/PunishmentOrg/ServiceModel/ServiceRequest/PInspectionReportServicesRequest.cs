using Anu.PunishmentOrg.ServiceModel.ServiceContract;
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.ServiceRequest
{
    public class ReceivePInspectionReportRequest : PInspectionReport, IRequestMessage
        {
        public Request Request { get; set; }

        public ReceivePInspectionReportRequest()
        {
            Request = new Request();
        }
    }
        public class SendPInspectionReportRequest : PInspectionReport, IRequestMessage
        {
        public Request Request { get; set; }

        public SendPInspectionReportRequest()
        {
            Request = new Request();
        }
    }
        public class SendPInspectionReportStateRequest : PInspectionResponse, IRequestMessage
        {
        public Request Request { get; set; }

        public SendPInspectionReportStateRequest()
        {
            Request = new Request();
        }
    }

}
