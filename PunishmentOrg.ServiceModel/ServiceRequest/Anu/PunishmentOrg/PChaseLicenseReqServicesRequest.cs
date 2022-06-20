
using Anu.PunishmentOrg.ServiceContract;
using ServiceModel.Commons.ServiceRequest;

namespace ServiceRequest.Anu.PunishmentOrg
{
        public class ReceivePChaseLicenseReqRequest : PChaseLicenseReq, IRequestMessage
        {
        }
        public class ReceivePChaseLicenseReqResultFromJudiciaryRequest : PChaseLicenseReq, IRequestMessage
        {
        }
        public class SendPChaseLicenseReqRequest : PChaseLicenseReqResponse, IRequestMessage
        {
        }
        public class SendPChaseLicenseReqResultFromJudiciaryRequest : PChaseLicenseReqResponse, IRequestMessage
        {
        }

}
