﻿using Anu.Commons.ServiceModel.SeviceRequest;
using Anu.PunishmentOrg.ServiceModel.ServiceContract;

namespace Anu.PunishmentOrg.ServiceModel.ServiceRequest
{
    public class ReceiveFromOtherOrgRequest : PDiscoveryMinutes, IRequestMessage
    {
        public Request Request { get; set; }

        public ReceiveFromOtherOrgRequest()
        {
            Request = new Request();
        }
    }
    public class ReceivePDiscoveryMinutesRequest : PDiscoveryMinutes, IRequestMessage
    {
        public Request Request { get; set; }

        public ReceivePDiscoveryMinutesRequest()
        {
            Request = new Request();
        }
    }
    public class ReceivePDiscoveryReportRequest : PDiscoveryMinutes, IRequestMessage
    {
        public Request Request { get; set; }

        public ReceivePDiscoveryReportRequest()
        {
            Request = new Request();
        }
    }
    public class SendPDiscoveryMinutesRequest : PDiscoveryMinutesResponse, IRequestMessage
    {
        public Request Request { get; set; }

        public SendPDiscoveryMinutesRequest()
        {
            Request = new Request();
        }
    }
    public class SendPDiscoveryMinutesNewRequest : PDiscoveryMinutes, IRequestMessage
    {
        public Request Request { get; set; }

        public SendPDiscoveryMinutesNewRequest()
        {
            Request = new Request();
        }
    }
    public class SendPDiscoveryReportRequest : PDiscoveryMinutesResponse, IRequestMessage
    {
        public Request Request { get; set; }

        public SendPDiscoveryReportRequest()
        {
            Request = new Request();
        }
    }
    public class SendPDiscoveryMinutesStateRequest : PDiscoveryMinutesStateResponse, IRequestMessage
    {
        public Request Request { get; set; }

        public SendPDiscoveryMinutesStateRequest()
        {
            Request = new Request();
        }
    }

}
