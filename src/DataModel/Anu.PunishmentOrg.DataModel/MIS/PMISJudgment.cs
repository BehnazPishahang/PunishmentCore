

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.MIS
{
    public abstract class PMISJudgmentBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("JUDGEDATETIME")]
        public virtual string? JudgeDateTime { get; set; }

        [Column("JUDGETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUJudgeType? JudgeType { get; set; }

        [Column("PENALTYAMOUNTFORGOVERMENT")]
        public virtual decimal? PenaltyAmountForGoverment { get; set; }

        [Column("PENALTYAMOUNTFORPLAINTIFF")]
        public virtual decimal? PenaltyAmountForPlaintiff { get; set; }

        [Column("STATISTICSTATUS")]
        public virtual Anu.PunishmentOrg.Enumerations.PUStatisticStatus? StatisticStatus { get; set; }

        [ForeignKey("GUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.GUnitType? TheGUnitType { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [InverseProperty("ThePMISJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISJudgmentCase>? ThePMISJudgmentCaseList { get; set; }

        [ForeignKey("PMISJUDGMENTCITYID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePMISJudgmentCity { get; set; }

        [ForeignKey("PMISJUDGMENTCOMPLEXID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePMISJudgmentComplex { get; set; }

        [ForeignKey("PMISJUDGMENTOSTANID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePMISJudgmentOstan { get; set; }

        [ForeignKey("PMISJUDGMENTSPECIALID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePMISJudgmentSpecial { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PMISJUDGMENT")]
    public partial class PMISJudgment : PMISJudgmentBase
    {
    }
    }