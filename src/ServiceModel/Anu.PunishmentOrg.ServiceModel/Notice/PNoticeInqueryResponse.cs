
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("PNoticeInqueryResponse")]
    public class PNoticeInqueryResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public PNoticeInquery PNotice { get; set; }

        public PNoticeInqueryResponse()
        {
            Result = new Result();
            PNotice = new PNoticeInquery();
        }

    }

    public class PNoticeInquery : IPaging
    {
        public PNoticeInquery()
        {
            PNoticeList = new List<PNoticeContract>();
            Page = new Page();
        }
        public List<PNoticeContract> PNoticeList { get; set; }
        public Page Page { get; set; }
    }
}
