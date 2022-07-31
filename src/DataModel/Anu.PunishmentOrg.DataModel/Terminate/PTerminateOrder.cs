

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PTerminateOrderBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("STATISTICSTATUS")]
        public virtual Anu.PunishmentOrg.Enumerations.PUStatisticStatus? StatisticStatus { get; set; }

        [Unicode(false)]
        [Column("TERMINATEDATETIME")]
        public virtual string? TerminateDateTime { get; set; }

        [Unicode(false)]
        [Column("TERMINATETEXT")]
        public virtual string? TerminateText { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePTerminateOrder")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrderCase>? ThePTerminateOrderCaseList { get; set; }

        [InverseProperty("ThePTerminateOrder")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrderTriple>? ThePTerminateOrderTripleList { get; set; }

        [InverseProperty("ThePTerminateOrder")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrderUnit>? ThePTerminateOrderUnitList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PTERMINATEORDER")]
    public partial class PTerminateOrder : PTerminateOrderBase
    {
    }
    }