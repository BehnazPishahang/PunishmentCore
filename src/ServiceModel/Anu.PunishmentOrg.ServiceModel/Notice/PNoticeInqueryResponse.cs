using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("PNoticeInqueryResponse")]
    public class PNoticeInqueryResponse : IResponseMessage
    {
        public PNoticeInqueryResponse()
        {
            Result = new Result();
            ThePNoticeContractList = new Page<List<Anu.PunishmentOrg.ServiceModel.Notice.PNoticeContract>>();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("ابلاغنامه در سرویس")]
        public Page<List<Anu.PunishmentOrg.ServiceModel.Notice.PNoticeContract>>? ThePNoticeContractList { get; set; }

        public Result Result { get; set; }
    }
}
