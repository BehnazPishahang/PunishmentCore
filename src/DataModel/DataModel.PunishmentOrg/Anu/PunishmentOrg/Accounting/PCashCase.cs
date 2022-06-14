

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Accounting
{
    public abstract class PCashCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PCASHID")]
		public virtual Anu.PunishmentOrg.Accounting.PCash? ThePCash { get; set; }

    }
    [Table("PCASHCASE")]
    public partial class PCashCase : PCashCaseBase { }

    }


