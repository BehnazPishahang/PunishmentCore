

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PTerminateOrderTripleBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBTERMINATEREASONID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBTerminateReason? ThePBTerminateReason { get; set; }

		[ForeignKey("PCASETRIPLEID")]
		public virtual Anu.PunishmentOrg.Case.PCaseTriple? ThePCaseTriple { get; set; }

		[ForeignKey("PTERMINATEORDERID")]
		public virtual Anu.PunishmentOrg.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

    }
    [Table("PTERMINATEORDERTRIPLE")]
    public partial class PTerminateOrderTriple : PTerminateOrderTripleBase { }

    }


