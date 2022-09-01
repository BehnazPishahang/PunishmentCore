
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("PNoticeInqueryRequest")]
    public class PNoticeInqueryRequest : IRequestMessage, IPaging
    {
        public Request Request { get; set; }
        public PNoticePersonContract PNoticePersonContract { get; set; }
        public Page Page { get; set; }

        public PNoticeInqueryRequest()
        {
            Request = new Request();
            PNoticePersonContract = new PNoticePersonContract();
            Page = new Page();
        }

    }
}
