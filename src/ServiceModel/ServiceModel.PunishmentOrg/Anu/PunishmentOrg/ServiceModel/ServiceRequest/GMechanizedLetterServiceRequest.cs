using Anu.Commons.ServiceModel.SeviceRequest;
using Anu.PunishmentOrg.ServiceModel.ServiceContract;

namespace Anu.PunishmentOrg.ServiceModel.ServiceRequest
{
    public class ReceiveGMechanizedLetterRequest : GMechanizedLetter, IRequestMessage
    {
        public Request Request { get; set; }

        public ReceiveGMechanizedLetterRequest()
        {
            Request = new Request();
        }
    }
    public class ReceiveGMechanizedLetterRevionSubjectRequest : GMechanizedLetterFields, IRequestMessage
    {
        public Request Request { get; set; }

        public ReceiveGMechanizedLetterRevionSubjectRequest()
        {
            Request = new Request();
        }
    }
    public class SendLetterRequest : GMechanizedLetter, IRequestMessage
    {
        public Request Request { get; set; }

        public SendLetterRequest()
        {
            Request = new Request();
        }
    }

}
