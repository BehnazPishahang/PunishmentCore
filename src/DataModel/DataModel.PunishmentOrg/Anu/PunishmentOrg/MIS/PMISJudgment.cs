

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.MIS
{
    public abstract class PMISJudgmentBase : PunishmentOrgEntity<string>
    {

		[Column("JUDGEDATETIME")]
		public virtual string? JudgeDateTime { get; set; }

		[Column("JUDGETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUJudgeType? JudgeType { get; set; }

		[Column("PENALTYAMOUNTFORGOVERMENT")]
		public virtual decimal? PenaltyAmountForGoverment { get; set; }

		[Column("PENALTYAMOUNTFORPLAINTIFF")]
		public virtual decimal? PenaltyAmountForPlaintiff { get; set; }

		[Column("STATISTICSTATUS")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUStatisticStatus? StatisticStatus { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[InverseProperty("ThePMISJudgment")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISJudgmentCase>? ThePMISJudgmentCaseList { get; set; }

		[ForeignKey("PMISJUDGMENTCITYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePMISJudgmentCity { get; set; }

		[ForeignKey("PMISJUDGMENTCOMPLEXID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePMISJudgmentComplex { get; set; }

		[ForeignKey("PMISJUDGMENTOSTANID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePMISJudgmentOstan { get; set; }

		[ForeignKey("PMISJUDGMENTSPECIALID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePMISJudgmentSpecial { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PMISJUDGMENT")]
    public partial class PMISJudgment : PMISJudgmentBase { }

    }


