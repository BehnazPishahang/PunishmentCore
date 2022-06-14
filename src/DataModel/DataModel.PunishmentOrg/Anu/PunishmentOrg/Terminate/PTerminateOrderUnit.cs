

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PTerminateOrderUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PTERMINATEORDERID")]
		public virtual Anu.PunishmentOrg.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

    }
    [Table("PTERMINATEORDERUNIT")]
    public partial class PTerminateOrderUnit : PTerminateOrderUnitBase { }

    }


