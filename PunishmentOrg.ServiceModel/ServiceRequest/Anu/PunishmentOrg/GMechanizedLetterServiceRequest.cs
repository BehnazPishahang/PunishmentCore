﻿using ServiceModel.Commons.ServiceRequest;
using ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract;

namespace ServiceRequest.Anu.PunishmentOrg
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
