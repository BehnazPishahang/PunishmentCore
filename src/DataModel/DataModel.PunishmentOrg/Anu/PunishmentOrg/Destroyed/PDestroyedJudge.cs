

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedJudgeBase : PunishmentOrgEntity<string>
    {

		[Column("CMSNO")]
		public virtual string? CMSNo { get; set; }

		[Column("JUDGEDATE")]
		public virtual string? JudgeDate { get; set; }

		[Column("MANUALNO")]
		public virtual string? ManualNo { get; set; }

		[ForeignKey("PBJUDGESUBJECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBJudgeSubjectType? ThePBJudgeSubjectType { get; set; }

		[ForeignKey("PDESTROYEDCASEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedCase? ThePDestroyedCase { get; set; }

		[InverseProperty("ThePDestroyedJudge")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedJudgeBindingSbj>? ThePDestroyedJudgeBindingSbjList { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PDESTROYEDJUDGE")]
    public partial class PDestroyedJudge : PDestroyedJudgeBase { }

    }


