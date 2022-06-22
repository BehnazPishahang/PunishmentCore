

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentBindSbjProductBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEPRODUCTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseProduct? ThePCaseProduct { get; set; }

		[ForeignKey("PJUDGMENTBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgmentBindingSubject? ThePJudgmentBindingSubject { get; set; }

    }
    [Table("PJUDGMENTBINDSBJPRODUCT")]
    public partial class PJudgmentBindSbjProduct : PJudgmentBindSbjProductBase { }

    }


