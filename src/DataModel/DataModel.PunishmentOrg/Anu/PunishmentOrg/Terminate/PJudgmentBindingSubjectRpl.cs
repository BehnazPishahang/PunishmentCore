

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentBindingSubjectRplBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[ForeignKey("PJUDGMENTBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgmentBindingSubject? ThePJudgmentBindingSubject { get; set; }

    }
    [Table("PJUDGMENTBINDINGSUBJECTRPL")]
    public partial class PJudgmentBindingSubjectRpl : PJudgmentBindingSubjectRplBase { }

    }


