

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportInspectorBase : PunishmentOrgEntity<string>
    {

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("INSPECTORCODE")]
        public virtual string? InspectorCode { get; set; }

        [Column("INSPECTORPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.PUInspectorPost? InspectorPost { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

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