

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PTerminateOrderCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PTERMINATEORDERID")]
		public virtual Anu.PunishmentOrg.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

    }
    [Table("PTERMINATEORDERCASE")]
    public partial class PTerminateOrderCase : PTerminateOrderCaseBase { }

    }


