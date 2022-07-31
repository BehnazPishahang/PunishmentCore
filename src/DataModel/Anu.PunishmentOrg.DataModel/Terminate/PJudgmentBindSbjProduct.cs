

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentBindSbjProductBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEPRODUCTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseProduct? ThePCaseProduct { get; set; }

        [ForeignKey("PJUDGMENTBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubject? ThePJudgmentBindingSubject { get; set; }

    }

    [Table("PJUDGMENTBINDSBJPRODUCT")]
    public partial class PJudgmentBindSbjProduct : PJudgmentBindSbjProductBase
    {
    }
    }