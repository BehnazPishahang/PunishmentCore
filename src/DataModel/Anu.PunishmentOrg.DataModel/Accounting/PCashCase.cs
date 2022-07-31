

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PCashCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCASHID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PCash? ThePCash { get; set; }

    }

    [Table("PCASHCASE")]
    public partial class PCashCase : PCashCaseBase
    {
    }
    }