
using Anu.PunishmentOrg.ServiceContract;
using ServiceModel.Commons.ServiceRequest;

namespace ServiceRequest.Anu.PunishmentOrg
{
        public class ReceiveFromOtherOrgRequest : PDiscoveryMinutes, IRequestMessage
        {
        }
        public class ReceivePDiscoveryMinutesRequest : PDiscoveryMinutes, IRequestMessage
        {
        }
        public class ReceivePDiscoveryReportRequest : PDiscoveryMinutes, IRequestMessage
        {
        }
        public class SendPDiscoveryMinutesRequest : PDiscoveryMinutesResponse, IRequestMessage
        {
        }
        public class SendPDiscoveryMinutesNewRequest : PDiscoveryMinutes, IRequestMessage
        {
        }
        public class SendPDiscoveryReportRequest : PDiscoveryMinutesResponse, IRequestMessage
        {
        }
        public class SendPDiscoveryMinutesStateRequest : PDiscoveryMinutesStateResponse, IRequestMessage
        {
        }

}
