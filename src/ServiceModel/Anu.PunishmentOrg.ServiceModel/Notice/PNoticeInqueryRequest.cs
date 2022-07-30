
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("PNoticeInqueryRequest")]
    public class PNoticeInqueryRequest : PNoticePersonContract, IRequestMessage
    {
        public Request Request { get; set; }

        public PNoticeInqueryRequest()
        {
            Request = new Request();
        }

    }
}
