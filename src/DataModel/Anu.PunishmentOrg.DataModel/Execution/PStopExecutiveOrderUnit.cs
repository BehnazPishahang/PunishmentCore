

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PStopExecutiveOrderUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PSTOPEXECUTIVEORDERID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PStopExecutiveOrder? ThePStopExecutiveOrder { get; set; }

    }

    [Table("PSTOPEXECUTIVEORDERUNIT")]
    public partial class PStopExecutiveOrderUnit : PStopExecutiveOrderUnitBase
    {
    }
    }