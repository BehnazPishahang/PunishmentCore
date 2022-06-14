

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PCaseProductViolationBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEPRODUCTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseProduct? ThePCaseProduct { get; set; }

		[ForeignKey("PCASEVIOLATIONID")]
		public virtual Anu.PunishmentOrg.Case.PCaseViolation? ThePCaseViolation { get; set; }

    }
    [Table("PCASEPRODUCTVIOLATION")]
    public partial class PCaseProductViolation : PCaseProductViolationBase { }

    }


