using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentTripleBase : PunishmentOrgEntity<string>
    {

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PBJUDGESUBJECTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBJudgeSubjectType? ThePBJudgeSubjectType { get; set; }

        [ForeignKey("PCASETRIPLEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseTriple? ThePCaseTriple { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [InverseProperty("ThePJudgmentTriple")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubTriple>? ThePJudgmentBindingSubTripleList { get; set; }

        }

    [Table("PJUDGMENTTRIPLE")]
    public partial class PJudgmentTriple : PJudgmentTripleBase
    {
    }
    }