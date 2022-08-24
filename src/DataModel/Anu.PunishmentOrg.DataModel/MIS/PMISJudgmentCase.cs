using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.MIS
{
    public abstract class PMISJudgmentCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PMISJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISJudgment? ThePMISJudgment { get; set; }

        }

    [Table("PMISJUDGMENTCASE")]
    public partial class PMISJudgmentCase : PMISJudgmentCaseBase
    {
    }
    }