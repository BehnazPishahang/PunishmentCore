

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentBindingSubTripleBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PJUDGMENTBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgmentBindingSubject? ThePJudgmentBindingSubject { get; set; }

		[ForeignKey("PJUDGMENTTRIPLEID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgmentTriple? ThePJudgmentTriple { get; set; }

    }
    [Table("PJUDGMENTBINDINGSUBTRIPLE")]
    public partial class PJudgmentBindingSubTriple : PJudgmentBindingSubTripleBase { }

    }


