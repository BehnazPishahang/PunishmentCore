

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Execution
{
    public abstract class PStopExecutiveOrderUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PSTOPEXECUTIVEORDERID")]
		public virtual Anu.PunishmentOrg.Execution.PStopExecutiveOrder? ThePStopExecutiveOrder { get; set; }

    }
    [Table("PSTOPEXECUTIVEORDERUNIT")]
    public partial class PStopExecutiveOrderUnit : PStopExecutiveOrderUnitBase { }

    }


