using Anu.PunishmentOrg.ServiceModel.ServiceContract;
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.ServiceRequest
{
    public class ReceivePChaseLicenseReqRequest : PChaseLicenseReq, IRequestMessage
        {
        public Request Request { get; set; }

        public ReceivePChaseLicenseReqRequest()
        {
            Request = new Request();
        }
    }
        public class ReceivePChaseLicenseReqResultFromJudiciaryRequest : PChaseLicenseReq, IRequestMessage
        {
        public Request Request { get; set; }

        public ReceivePChaseLicenseReqResultFromJudiciaryRequest()
        {
            Request = new Request();
        }
    }
        public class SendPChaseLicenseReqRequest : PChaseLicenseReqResponse, IRequestMessage
        {
        public Request Request { get; set; }

        public SendPChaseLicenseReqRequest()
        {
            Request = new Request();
        }
    }
        public class SendPChaseLicenseReqResultFromJudiciaryRequest : PChaseLicenseReqResponse, IRequestMessage
        {
        public Request Request { get; set; }

        public SendPChaseLicenseReqResultFromJudiciaryRequest()
        {
            Request = new Request();
        }
    }

}
