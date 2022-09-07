
using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("ExportPNoticeRequest")]
    public class ExportPNoticeRequest
    {
        public ExportPNoticeRequest()
        {
            ThePNoticeNoInputContract = new PNoticeNoInputContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ابلاغ در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Notice.PNoticeNoInputContract? ThePNoticeNoInputContract { get; set; }
    }
}
