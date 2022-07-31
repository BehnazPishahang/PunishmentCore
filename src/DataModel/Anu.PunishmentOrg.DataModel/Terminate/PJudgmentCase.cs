

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

    }

    [Table("PJUDGMENTCASE")]
    public partial class PJudgmentCase : PJudgmentCaseBase
    {
    }
    }