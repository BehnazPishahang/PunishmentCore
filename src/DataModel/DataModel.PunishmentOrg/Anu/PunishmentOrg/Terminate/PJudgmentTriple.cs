

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentTripleBase : PunishmentOrgEntity<string>
    {

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[ForeignKey("PBJUDGESUBJECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBJudgeSubjectType? ThePBJudgeSubjectType { get; set; }

		[ForeignKey("PCASETRIPLEID")]
		public virtual Anu.PunishmentOrg.Case.PCaseTriple? ThePCaseTriple { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[InverseProperty("ThePJudgmentTriple")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentBindingSubTriple>? ThePJudgmentBindingSubTripleList { get; set; }

    }
    [Table("PJUDGMENTTRIPLE")]
    public partial class PJudgmentTriple : PJudgmentTripleBase { }

    }


