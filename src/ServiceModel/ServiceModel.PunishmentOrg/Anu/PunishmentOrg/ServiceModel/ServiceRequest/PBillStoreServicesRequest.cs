using Anu.PunishmentOrg.ServiceModel.ServiceContract;
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.ServiceRequest
{
    public class ReceivePBillStoreRequest : PBillStore, IRequestMessage
        {
        public Request Request { get; set; }

        public ReceivePBillStoreRequest()
        {
            Request = new Request();
        }
    }
        public class SendPBillStoreRequest : PBillStoreResponse, IRequestMessage
        {
        public Request Request { get; set; }

        public SendPBillStoreRequest()
        {
            Request = new Request();
        }
    }
        public class ReceivePBillStoreFromScmsRequest : PBillStoreFromScms, IRequestMessage
        {
        public Request Request { get; set; }

        public ReceivePBillStoreFromScmsRequest()
        {
            Request = new Request();
        }
    }

}
