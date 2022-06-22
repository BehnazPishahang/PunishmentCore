

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate
{
    public abstract class PTerminateOrderBase : PunishmentOrgEntity<string>
    {

		[Column("CASESNOSUBNO")]
		public virtual string? CasesNoSubno { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("STATISTICSTATUS")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUStatisticStatus? StatisticStatus { get; set; }

		[Column("TERMINATEDATETIME")]
		public virtual string? TerminateDateTime { get; set; }

		[Column("TERMINATETEXT")]
		public virtual string? TerminateText { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePTerminateOrder")]
		public virtual List<Anu.PunishmentOrg.Terminate.PTerminateOrderCase>? ThePTerminateOrderCaseList { get; set; }

		[InverseProperty("ThePTerminateOrder")]
		public virtual List<Anu.PunishmentOrg.Terminate.PTerminateOrderTriple>? ThePTerminateOrderTripleList { get; set; }

		[InverseProperty("ThePTerminateOrder")]
		public virtual List<Anu.PunishmentOrg.Terminate.PTerminateOrderUnit>? ThePTerminateOrderUnitList { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PTERMINATEORDER")]
    public partial class PTerminateOrder : PTerminateOrderBase { }

    }


