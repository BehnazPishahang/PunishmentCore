using Anu.PunishmentOrg.ServiceModel.ServiceContract;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponse
{
    public class ReceivePBillStoreResponse :PBillStoreResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceivePBillStoreResponse()
          {
              Result = new Result();
          }
        }
        public class SendPBillStoreResponse :PBillStore ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPBillStoreResponse()
          {
              Result = new Result();
          }
        }
        public class ReceivePBillStoreFromScmsResponse :PBillStoreResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceivePBillStoreFromScmsResponse()
          {
              Result = new Result();
          }
        }

}
