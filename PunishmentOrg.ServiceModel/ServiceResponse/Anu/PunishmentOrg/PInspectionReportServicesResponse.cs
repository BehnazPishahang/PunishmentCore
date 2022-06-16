
using Anu.PunishmentOrg.ServiceContract;
using ServiceModel.Commons.ServiceResponse;

namespace ServiceResponse.Anu.PunishmentOrg
{
    public class ReceivePInspectionReportResponse :PInspectionResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceivePInspectionReportResponse()
          {
              Result = new Result();
          }
        }
        public class SendPInspectionReportResponse :PInspectionReport ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPInspectionReportResponse()
          {
              Result = new Result();
          }
        }
        public class SendPInspectionReportStateResponse :PInspectionResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPInspectionReportStateResponse()
          {
              Result = new Result();
          }
        }

}
