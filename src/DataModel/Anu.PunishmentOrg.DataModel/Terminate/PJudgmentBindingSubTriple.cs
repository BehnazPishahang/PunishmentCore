using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentBindingSubTripleBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PJUDGMENTBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubject? ThePJudgmentBindingSubject { get; set; }

        [ForeignKey("PJUDGMENTTRIPLEID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgmentTriple? ThePJudgmentTriple { get; set; }

        }

    [Table("PJUDGMENTBINDINGSUBTRIPLE")]
    public partial class PJudgmentBindingSubTriple : PJudgmentBindingSubTripleBase
    {
    }
    }