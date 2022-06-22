

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PRegistaryTimeBase : PunishmentOrgEntity<string>
    {

		[Column("CASESNOSUBNO")]
		public virtual string? CasesNoSubno { get; set; }

		[Column("ENDTIME")]
		public virtual string? EndTime { get; set; }

		[Column("REGISTERDATE")]
		public virtual string? RegisterDate { get; set; }

		[Column("STARTTIME")]
		public virtual string? StartTime { get; set; }

		[ForeignKey("PBRENEWALTIMETYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBRenewalTimeType? ThePBRenewalTimeType { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[InverseProperty("ThePRegistaryTime")]
		public virtual List<Anu.PunishmentOrg.Case.PRegistaryTimeCase>? ThePRegistaryTimeCaseList { get; set; }

		[ForeignKey("PTERMINATEORDERID")]
		public virtual Anu.PunishmentOrg.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TIMERESULT")]
		public virtual string? TimeResult { get; set; }

		[Column("TIMESTATUS")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PURegisterTimeStatus? TimeStatus { get; set; }

		[Column("TIMETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PURegisterTimeType? TimeType { get; set; }

    }
    [Table("PREGISTARYTIME")]
    public partial class PRegistaryTime : PRegistaryTimeBase { }

    }


