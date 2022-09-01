
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("ExportPNoticeResponse")]
    public class ExportPNoticeResponse : IResponseMessage
    {
        public ExportPNoticeResponse()
        {
            Result = new Result();
            ThePNoticeExportContract = new Anu.PunishmentOrg.ServiceModel.Notice.PNoticeExportContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("گزارش ابلاغ در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Notice.PNoticeExportContract? ThePNoticeExportContract { get; set; }

        public Result Result { get; set; }


    }
}
