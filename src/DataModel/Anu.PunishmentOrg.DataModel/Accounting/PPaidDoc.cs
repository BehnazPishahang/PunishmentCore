using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PPaidDocBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PPAIDID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PPaid? ThePPaid { get; set; }

        }

    [Table("PPAIDDOC")]
    public partial class PPaidDoc : PPaidDocBase
    {
    }
    }