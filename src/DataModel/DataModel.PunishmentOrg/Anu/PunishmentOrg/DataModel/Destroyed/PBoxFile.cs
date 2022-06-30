

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PBoxFileBase : PunishmentOrgEntity<string>
    {

        [Column("BOXFILENO")]
        public virtual string? BoxFileNo { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("ENDYEAR")]
        public virtual string? EndYear { get; set; }

        [Column("STEPNO")]
        public virtual Anu.PunishmentOrg.Enumerations.DestroyedCaseStep? StepNo { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePBoxFile")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCase>? ThePDestroyedCaseList { get; set; }

        [InverseProperty("ThePBoxFile")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinuteBoxFiles>? ThePDestroyedMinuteBoxFilesList { get; set; }

        [ForeignKey("REGISTRARID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegistrar { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PBOXFILE")]
    public partial class PBoxFile : PBoxFileBase
    {
    }
}