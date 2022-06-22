

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PStopExecutiveOrderBase : PunishmentOrgEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("ENDSTOPDATE")]
		public virtual string? EndStopDate { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("OFFICECOURTNUMBER")]
		public virtual long? OfficeCourtNumber { get; set; }

		[Column("ORDERTEXT")]
		public virtual string? OrderText { get; set; }

		[Column("RESTARTORDERLETTERDATE")]
		public virtual string? RestartOrderLetterDate { get; set; }

		[Column("RESTARTORDERLETTERNO")]
		public virtual string? RestartOrderLetterNo { get; set; }

		[Column("STARTSTOPDATE")]
		public virtual string? StartStopDate { get; set; }

		[Column("STOPORDERLETTERDATE")]
		public virtual string? StopOrderLetterDate { get; set; }

		[Column("STOPORDERLETTERNO")]
		public virtual string? StopOrderLetterNo { get; set; }

		[Column("SUPREMECOURTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.SupremeCourtType? SupremeCourtType { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePStopExecutiveOrder")]
		public virtual List<Anu.PunishmentOrg.Execution.PStopExecutiveOrderUnit>? ThePStopExecutiveOrderUnitList { get; set; }

		[ForeignKey("PUOISSUERUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePUOIssuerUnit { get; set; }

		[ForeignKey("REGISTERUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheRegisterUnit { get; set; }

    }
    [Table("PSTOPEXECUTIVEORDER")]
    public partial class PStopExecutiveOrder : PStopExecutiveOrderBase { }

    }


