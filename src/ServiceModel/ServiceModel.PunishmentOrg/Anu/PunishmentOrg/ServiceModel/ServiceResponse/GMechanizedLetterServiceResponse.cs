using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.ServiceContract;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponse
{
    public class ReceiveGMechanizedLetterResponse :SendLetterResponseMessage ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceiveGMechanizedLetterResponse()
          {
              Result = new Result();
          }
        }
        public class ReceiveGMechanizedLetterRevionSubjectResponse :SendLetterResponseMessage ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceiveGMechanizedLetterRevionSubjectResponse()
          {
              Result = new Result();
          }
        }
        public class SendLetterResponse :SendLetterResponseMessage ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendLetterResponse()
          {
              Result = new Result();
          }
        }

}
