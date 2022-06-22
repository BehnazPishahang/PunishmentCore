using ServiceModel.Commons.ServiceResponse;
using ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract;

namespace ServiceResponse.Anu.PunishmentOrg
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
