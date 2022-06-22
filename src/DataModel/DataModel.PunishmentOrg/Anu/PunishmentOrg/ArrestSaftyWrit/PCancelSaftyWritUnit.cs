

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.ArrestSaftyWrit
{
    public abstract class PCancelSaftyWritUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PCANCELSAFTYWRITID")]
		public virtual Anu.PunishmentOrg.ArrestSaftyWrit.PCancelSaftyWrit? ThePCancelSaftyWrit { get; set; }

    }
    [Table("PCANCELSAFTYWRITUNIT")]
    public partial class PCancelSaftyWritUnit : PCancelSaftyWritUnitBase { }

    }


