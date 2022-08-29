
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("PInspectionReportStateRequest")]
    public class PInspectionReportStateRequest
    {
        public PInspectionReportStateRequest()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("ورودی سرويس وضعیت گزارش بازرسي")]
        public Anu.PunishmentOrg.ServiceModel.InspectionReport.PInspectionReportStateInputContract? ThePInspectionReportStateInputContract { get; set; }



    }
}
