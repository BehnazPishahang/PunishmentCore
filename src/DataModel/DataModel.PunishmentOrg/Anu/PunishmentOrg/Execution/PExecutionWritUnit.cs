

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Execution
{
    public abstract class PExecutionWritUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PEXECUTIONWRITID")]
		public virtual Anu.PunishmentOrg.Execution.PExecutionWrit? ThePExecutionWrit { get; set; }

    }
    [Table("PEXECUTIONWRITUNIT")]
    public partial class PExecutionWritUnit : PExecutionWritUnitBase { }

    }


