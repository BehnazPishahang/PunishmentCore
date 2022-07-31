

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PPrisonerBindingSubjectBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("OLDCASEBINDINGIDS")]
        public virtual string? OldCaseBindingIDs { get; set; }

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PPRISONERID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PPrisoner? ThePPrisoner { get; set; }

    }

    [Table("PPRISONERBINDINGSUBJECT")]
    public partial class PPrisonerBindingSubject : PPrisonerBindingSubjectBase
    {
    }
    }