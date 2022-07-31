

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentBindingSubjectRplBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [ForeignKey("PJUDGMENTBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubject? ThePJudgmentBindingSubject { get; set; }

    }

    [Table("PJUDGMENTBINDINGSUBJECTRPL")]
    public partial class PJudgmentBindingSubjectRpl : PJudgmentBindingSubjectRplBase
    {
    }
    }