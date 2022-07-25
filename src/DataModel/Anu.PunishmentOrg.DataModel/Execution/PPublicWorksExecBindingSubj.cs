

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PPublicWorksExecBindingSubjBase : PunishmentOrgEntity<string>
    {

        [Column("OLDCASEBINDINGIDS")]
        public virtual string? OldCaseBindingIDs { get; set; }

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PPUBLICWORKSEXECID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PPublicWorksExec? ThePPublicWorksExec { get; set; }

    }

    [Table("PPUBLICWORKSEXECBINDINGSUBJ")]
    public partial class PPublicWorksExecBindingSubj : PPublicWorksExecBindingSubjBase
    {
    }
}