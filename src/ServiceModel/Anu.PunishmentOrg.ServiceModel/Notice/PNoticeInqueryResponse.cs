
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("PNoticeInqueryResponse")]
    public class PNoticeInqueryResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public Page<List<PNoticeContract>> PNotice { get; set; }

        public PNoticeInqueryResponse()
        {
            Result = new Result();
            PNotice = new Page<List<PNoticeContract>>();
        }

    }
}
