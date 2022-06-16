
using Anu.PunishmentOrg.ServiceContract;
using ServiceModel.Commons.ServiceRequest;

namespace ServiceRequest.Anu.PunishmentOrg
{
        public class ReceivePInspectionReportRequest : PInspectionReport, IRequestMessage
        {
        }
        public class SendPInspectionReportRequest : PInspectionReport, IRequestMessage
        {
        }
        public class SendPInspectionReportStateRequest : PInspectionResponse, IRequestMessage
        {
        }

}
