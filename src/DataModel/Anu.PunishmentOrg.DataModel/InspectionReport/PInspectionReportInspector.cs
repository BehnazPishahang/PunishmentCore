using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportInspectorBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("INSPECTORCODE")]
        public virtual string? InspectorCode { get; set; }

        [Column("INSPECTORPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.PUInspectorPost? InspectorPost { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Unicode(false)]
        [Column("SYSTEMNAME")]
        public virtual string? SystemName { get; set; }

        [ForeignKey("PINSPECTIONREPORTID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

        }

    [Table("PINSPECTIONREPORTINSPECTOR")]
    public partial class PInspectionReportInspector : PInspectionReportInspectorBase
    {
    }
    }