

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PConvictsDatabaseJudgeBase : PunishmentOrgEntity<string>
    {

		[Column("JUDGEDATE")]
		public virtual string? JudgeDate { get; set; }

		[Column("JUDGENO")]
		public virtual string? JudgeNo { get; set; }

		[ForeignKey("EXECUTIVECASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? TheExecutiveCase { get; set; }

		[ForeignKey("EXECUTIVEUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheExecutiveUnit { get; set; }

		[ForeignKey("PCONVICTSDATABASEID")]
		public virtual Anu.PunishmentOrg.Terminate.PConvictsDatabase? ThePConvictsDatabase { get; set; }

		[InverseProperty("ThePConvictsDatabaseJudge")]
		public virtual List<Anu.PunishmentOrg.Terminate.PConvictsDatabaseBindingSuj>? ThePConvictsDatabaseBindingSujList { get; set; }

		[InverseProperty("ThePConvictsDatabaseJudge")]
		public virtual List<Anu.PunishmentOrg.Terminate.PConvictsDatabaseViolation>? ThePConvictsDatabaseViolationList { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PCONVICTSDATABASEJUDGE")]
    public partial class PConvictsDatabaseJudge : PConvictsDatabaseJudgeBase { }

    }


