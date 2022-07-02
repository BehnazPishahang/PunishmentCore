

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportAttachmentBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PINSPECTIONREPORTID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

    }

    [Table("PINSPECTIONREPORTATTACHMENT")]
    public partial class PInspectionReportAttachment : PInspectionReportAttachmentBase
    {
    }
}