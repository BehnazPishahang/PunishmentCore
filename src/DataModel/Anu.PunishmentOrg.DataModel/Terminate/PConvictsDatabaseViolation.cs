

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PConvictsDatabaseViolationBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBJUDGESUBJECTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBJudgeSubjectType? ThePBJudgeSubjectType { get; set; }

        [ForeignKey("PBVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

        [ForeignKey("PCONVICTSDATABASEJUDGEID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PConvictsDatabaseJudge? ThePConvictsDatabaseJudge { get; set; }

    }

    [Table("PCONVICTSDATABASEVIOLATION")]
    public partial class PConvictsDatabaseViolation : PConvictsDatabaseViolationBase
    {
    }
}