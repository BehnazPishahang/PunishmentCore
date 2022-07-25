

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportRetReasonBase : PunishmentOrgEntity<string>
    {

        [Column("RETURNREASON")]
        public virtual Anu.PunishmentOrg.Enumerations.InspectionReportReturnReason? ReturnReason { get; set; }

        [ForeignKey("PINSPECTIONREPORTID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

    }

    [Table("PINSPECTIONREPORTRETREASON")]
    public partial class PInspectionReportRetReason : PInspectionReportRetReasonBase
    {
    }
}