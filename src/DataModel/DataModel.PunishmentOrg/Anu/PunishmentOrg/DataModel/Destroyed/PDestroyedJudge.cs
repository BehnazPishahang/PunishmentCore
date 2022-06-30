

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Destroyed
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
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBJudgeSubjectType? ThePBJudgeSubjectType { get; set; }

        [ForeignKey("PDESTROYEDCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCase? ThePDestroyedCase { get; set; }

        [InverseProperty("ThePDestroyedJudge")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedJudgeBindingSbj>? ThePDestroyedJudgeBindingSbjList { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PDESTROYEDJUDGE")]
    public partial class PDestroyedJudge : PDestroyedJudgeBase
    {
    }
}