

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.ArrestSaftyWrit
{
    public abstract class PSaftyWritUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PSAFTYWRITID")]
		public virtual Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWrit? ThePSaftyWrit { get; set; }

    }
    [Table("PSAFTYWRITUNIT")]
    public partial class PSaftyWritUnit : PSaftyWritUnitBase { }

    }


