

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.ArrestSaftyWrit
{
    public abstract class PSaftyWritAcceptUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PSAFTYWRITACCEPTID")]
		public virtual Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWritAccept? ThePSaftyWritAccept { get; set; }

    }
    [Table("PSAFTYWRITACCEPTUNIT")]
    public partial class PSaftyWritAcceptUnit : PSaftyWritAcceptUnitBase { }

    }


