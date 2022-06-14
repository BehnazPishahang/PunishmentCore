

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentBindingSubjectPrsnBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[ForeignKey("PJUDGMENTBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgmentBindingSubject? ThePJudgmentBindingSubject { get; set; }

    }
    [Table("PJUDGMENTBINDINGSUBJECTPRSN")]
    public partial class PJudgmentBindingSubjectPrsn : PJudgmentBindingSubjectPrsnBase { }

    }


