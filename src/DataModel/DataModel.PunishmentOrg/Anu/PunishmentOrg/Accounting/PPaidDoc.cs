

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Accounting
{
    public abstract class PPaidDocBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PPAIDID")]
		public virtual Anu.PunishmentOrg.Accounting.PPaid? ThePPaid { get; set; }

    }
    [Table("PPAIDDOC")]
    public partial class PPaidDoc : PPaidDocBase { }

    }


