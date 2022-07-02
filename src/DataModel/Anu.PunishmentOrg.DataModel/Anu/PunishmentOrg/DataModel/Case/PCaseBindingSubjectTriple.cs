

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseBindingSubjectTripleBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PCASETRIPLEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseTriple? ThePCaseTriple { get; set; }

    }

    [Table("PCASEBINDINGSUBJECTTRIPLE")]
    public partial class PCaseBindingSubjectTriple : PCaseBindingSubjectTripleBase
    {
    }
}