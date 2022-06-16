
using Anu.PunishmentOrg.ServiceContract;
using ServiceModel.Commons.ServiceRequest;

namespace ServiceRequest.Anu.PunishmentOrg
{
        public class ReceiveGMechanizedLetterRequest : GMechanizedLetter, IRequestMessage
        {
        }
        public class ReceiveGMechanizedLetterRevionSubjectRequest : GMechanizedLetterFields, IRequestMessage
        {
        }
        public class SendLetterRequest : GMechanizedLetter, IRequestMessage
        {
        }

}
