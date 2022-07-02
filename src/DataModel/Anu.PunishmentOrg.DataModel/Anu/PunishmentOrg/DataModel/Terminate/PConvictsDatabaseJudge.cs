

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PConvictsDatabaseJudgeBase : PunishmentOrgEntity<string>
    {

        [Column("JUDGEDATE")]
        public virtual string? JudgeDate { get; set; }

        [Column("JUDGENO")]
        public virtual string? JudgeNo { get; set; }

        [ForeignKey("EXECUTIVECASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? TheExecutiveCase { get; set; }

        [ForeignKey("EXECUTIVEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheExecutiveUnit { get; set; }

        [ForeignKey("PCONVICTSDATABASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PConvictsDatabase? ThePConvictsDatabase { get; set; }

        [InverseProperty("ThePConvictsDatabaseJudge")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PConvictsDatabaseBindingSuj>? ThePConvictsDatabaseBindingSujList { get; set; }

        [InverseProperty("ThePConvictsDatabaseJudge")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PConvictsDatabaseViolation>? ThePConvictsDatabaseViolationList { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PCONVICTSDATABASEJUDGE")]
    public partial class PConvictsDatabaseJudge : PConvictsDatabaseJudgeBase
    {
    }
}