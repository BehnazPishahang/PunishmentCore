using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PMobilePatrolsBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("ENDTIME")]
        public virtual string? EndTime { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("PATROLDATE")]
        public virtual string? PatrolDate { get; set; }

        [Unicode(false)]
        [Column("STARTTIME")]
        public virtual string? StartTime { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePMobilePatrols")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsRegulatory>? ThePMobilePatrolsRegulatoryList { get; set; }

        [InverseProperty("ThePMobilePatrols")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTradeUnit>? ThePMobilePatrolsTradeUnitList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        }

    [Table("PMOBILEPATROLS")]
    public partial class PMobilePatrols : PMobilePatrolsBase
    {
    }
    }