using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PExecutionWritUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PEXECUTIONWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PExecutionWrit? ThePExecutionWrit { get; set; }

        }

    [Table("PEXECUTIONWRITUNIT")]
    public partial class PExecutionWritUnit : PExecutionWritUnitBase
    {
    }
    }