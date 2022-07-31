

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentViolatorBase : PunishmentOrgEntity<string>
    {

        [Column("PRESENTSTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUJudgementViolatorP? PresentState { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

    }

    [Table("PJUDGMENTVIOLATOR")]
    public partial class PJudgmentViolator : PJudgmentViolatorBase
    {
    }
    }