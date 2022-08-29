using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportRetReasonBase : PunishmentOrgEntity<string>
    {

        [Column("RETURNREASON")]
        public virtual Anu.PunishmentOrg.Enumerations.InspectionReportReturnReason? ReturnReason { get; set; }

        [ForeignKey("FIRSTREPORTID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport? TheFirstReport { get; set; }

        [ForeignKey("PINSPECTIONREPORTID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

        [ForeignKey("RELATEDCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? TheRelatedCase { get; set; }

        }

    [Table("PINSPECTIONREPORTRETREASON")]
    public partial class PInspectionReportRetReason : PInspectionReportRetReasonBase
    {
    }
    }