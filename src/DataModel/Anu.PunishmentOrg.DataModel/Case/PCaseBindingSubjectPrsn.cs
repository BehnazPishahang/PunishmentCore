

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseBindingSubjectPrsnBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

    }

    [Table("PCASEBINDINGSUBJECTPRSN")]
    public partial class PCaseBindingSubjectPrsn : PCaseBindingSubjectPrsnBase
    {
    }
    }