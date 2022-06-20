
using Anu.PunishmentOrg.ServiceContract;
using ServiceModel.Commons.ServiceRequest;

namespace ServiceRequest.Anu.PunishmentOrg
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
