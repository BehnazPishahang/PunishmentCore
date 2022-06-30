using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.ServiceContract;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponse
{
    public class ReceiveFromOtherOrgResponse :PDiscoveryMinutesResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceiveFromOtherOrgResponse()
          {
              Result = new Result();
          }
        }
        public class ReceivePDiscoveryMinutesResponse :PDiscoveryMinutesResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceivePDiscoveryMinutesResponse()
          {
              Result = new Result();
          }
        }
        public class ReceivePDiscoveryReportResponse :PDiscoveryMinutesResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceivePDiscoveryReportResponse()
          {
              Result = new Result();
          }
        }
        public class SendPDiscoveryMinutesResponse :PDiscoveryMinutes ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPDiscoveryMinutesResponse()
          {
              Result = new Result();
          }
        }
        public class SendPDiscoveryMinutesNewResponse :PDiscoveryMinutesResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPDiscoveryMinutesNewResponse()
          {
              Result = new Result();
          }
        }
        public class SendPDiscoveryReportResponse :PDiscoveryMinutes ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPDiscoveryReportResponse()
          {
              Result = new Result();
          }
        }
        public class SendPDiscoveryMinutesStateResponse :PDiscoveryMinutesStateResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPDiscoveryMinutesStateResponse()
          {
              Result = new Result();
          }
        }

}
