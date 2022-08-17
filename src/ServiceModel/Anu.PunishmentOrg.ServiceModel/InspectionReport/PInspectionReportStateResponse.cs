
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("PInspectionReportStateResponse")]
    public class PInspectionReportStateResponse : IResponseMessage
    {
        public PInspectionReportStateResponse()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("خروجی سرويس وضعیت گزارش بازرسي")]
        public Anu.PunishmentOrg.ServiceModel.InspectionReport.PInspectionReportStateContract? ThePInspectionReportStateContract { get; set; }

        public Result Result { get; set; }

    }
}
