
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("PNoticeInqueryRequest")]
    public class PNoticeInqueryRequest : IPaging
    {
        public PNoticeInqueryRequest()
        {
            ThePNoticePersonContract = new PNoticePersonContract();
            Page = new Page();
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ابلاغ شونده در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Notice.PNoticePersonContract? ThePNoticePersonContract { get; set; }

        public Page Page { get; set; }
    }
}
