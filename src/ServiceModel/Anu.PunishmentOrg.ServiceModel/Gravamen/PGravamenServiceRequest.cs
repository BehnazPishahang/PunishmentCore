
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("ورودی سرویس شکوائیه")]
    public class PGravamenServiceRequest : PGravamenContract, IRequestMessage
    {
        public Request Request { get; set; }

        public PGravamenServiceRequest()
        {
            Request = new Request();
        }

    }
}
