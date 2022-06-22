

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.InspectionReport
{
    public abstract class PMobilePatrolsBase : PunishmentOrgEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("ENDTIME")]
		public virtual string? EndTime { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PATROLDATE")]
		public virtual string? PatrolDate { get; set; }

		[Column("STARTTIME")]
		public virtual string? StartTime { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePMobilePatrols")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PMobilePatrolsRegulatory>? ThePMobilePatrolsRegulatoryList { get; set; }

		[InverseProperty("ThePMobilePatrols")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PMobilePatrolsTradeUnit>? ThePMobilePatrolsTradeUnitList { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PMOBILEPATROLS")]
    public partial class PMobilePatrols : PMobilePatrolsBase { }

    }


