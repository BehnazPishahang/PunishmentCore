
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("GetCountOfUnSeenPNoticeByUserRequest")]
    public class GetCountOfUnSeenPNoticeByUserRequest
    {
        public GetCountOfUnSeenPNoticeByUserRequest()
        {
            ThePNoticePersonContract = new PNoticePersonContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شخص ابلاغ شونده")]
        public Anu.PunishmentOrg.ServiceModel.Notice.PNoticePersonContract? ThePNoticePersonContract { get; set; }
    }
}
