
using Anu.PunishmentOrg.ServiceContract;
using ServiceModel.Commons.ServiceRequest;

namespace ServiceRequest.Anu.PunishmentOrg
{
        public class ReceivePBillStoreRequest : PBillStore, IRequestMessage
        {
        }
        public class SendPBillStoreRequest : PBillStoreResponse, IRequestMessage
        {
        }
        public class ReceivePBillStoreFromScmsRequest : PBillStoreFromScms, IRequestMessage
        {
        }

}
