

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PExecutionWritBindingSbjtBase : PunishmentOrgEntity<string>
    {

        [Column("DEBTREDUCTIONVALUE")]
        public virtual long? DebtReductionValue { get; set; }

        [Column("OLDCASEBINDINGIDS")]
        public virtual string? OldCaseBindingIDs { get; set; }

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PEXECUTIONWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PExecutionWrit? ThePExecutionWrit { get; set; }

    }

    [Table("PEXECUTIONWRITBINDINGSBJT")]
    public partial class PExecutionWritBindingSbjt : PExecutionWritBindingSbjtBase
    {
    }
}