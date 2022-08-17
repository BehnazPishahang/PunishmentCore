
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("خروجی سرويس وضعیت گزارش بازرسي")]
    public class PInspectionReportStateContract
    {
        public PInspectionReportStateContract()
        {
        }

        [System.ComponentModel.DisplayName("تاريخ وقت")]
        public string? RegisterDate { get; set; }



        [System.ComponentModel.DisplayName("وضعيت تجديد نظر")]
        public string? RevisionRequest { get; set; }



        [System.ComponentModel.DisplayName("شناسه يکتا")]
        public string? UniqueNo { get; set; }



        [System.ComponentModel.DisplayName("نام واحد")]
        public string? UnitName { get; set; }



        [System.ComponentModel.DisplayName("شماره واحد رسيدگي کننده")]
        public string? UnitNo { get; set; }



    }
}
