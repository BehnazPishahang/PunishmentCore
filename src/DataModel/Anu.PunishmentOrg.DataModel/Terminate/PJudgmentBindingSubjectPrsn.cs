

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentBindingSubjectPrsnBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [ForeignKey("PJUDGMENTBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubject? ThePJudgmentBindingSubject { get; set; }

    }

    [Table("PJUDGMENTBINDINGSUBJECTPRSN")]
    public partial class PJudgmentBindingSubjectPrsn : PJudgmentBindingSubjectPrsnBase
    {
    }
    }