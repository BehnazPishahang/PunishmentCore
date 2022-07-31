
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("PNoticeInqueryResponse")]
    public class PNoticeInqueryResponse : IResponseMessage
    {
        public Result Result { get; set; }
        public List<PNoticeContract> PNoticeList { get; set; }
        public PNoticeInqueryResponse()
        {
            Result = new Result();
            PNoticeList = new List<PNoticeContract>();
        }

    }
}
