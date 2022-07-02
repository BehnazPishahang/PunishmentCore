

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PExecutionWritAccountBase : PunishmentOrgEntity<string>
    {

        [Column("ACCOUNTNO")]
        public virtual string? AccountNo { get; set; }

        [ForeignKey("BANKID")]
        public virtual Anu.BaseInfo.DataModel.Types.Bank? TheBank { get; set; }

        [ForeignKey("PEXECUTIONWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PExecutionWrit? ThePExecutionWrit { get; set; }

    }

    [Table("PEXECUTIONWRITACCOUNT")]
    public partial class PExecutionWritAccount : PExecutionWritAccountBase
    {
    }
}