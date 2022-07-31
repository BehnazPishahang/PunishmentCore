

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseProductViolationBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEPRODUCTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseProduct? ThePCaseProduct { get; set; }

        [ForeignKey("PCASEVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseViolation? ThePCaseViolation { get; set; }

    }

    [Table("PCASEPRODUCTVIOLATION")]
    public partial class PCaseProductViolation : PCaseProductViolationBase
    {
    }
    }