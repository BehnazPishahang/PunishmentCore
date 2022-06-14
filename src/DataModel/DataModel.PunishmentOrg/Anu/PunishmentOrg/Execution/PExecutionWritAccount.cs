

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Execution
{
    public abstract class PExecutionWritAccountBase : PunishmentOrgEntity<string>
    {

		[Column("ACCOUNTNO")]
		public virtual string? AccountNo { get; set; }

		[ForeignKey("BANKID")]
		public virtual Anu.BaseInfo.Types.Bank? TheBank { get; set; }

		[ForeignKey("PEXECUTIONWRITID")]
		public virtual Anu.PunishmentOrg.Execution.PExecutionWrit? ThePExecutionWrit { get; set; }

    }
    [Table("PEXECUTIONWRITACCOUNT")]
    public partial class PExecutionWritAccount : PExecutionWritAccountBase { }

    }


