

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PCaseWrapBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("MAINCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? TheMainCase { get; set; }

		[ForeignKey("WRAPCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? TheWrapCase { get; set; }

    }
    [Table("PCASEWRAP")]
    public partial class PCaseWrap : PCaseWrapBase { }

    }


