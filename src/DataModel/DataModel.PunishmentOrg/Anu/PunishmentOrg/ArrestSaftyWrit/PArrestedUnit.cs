

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.ArrestSaftyWrit
{
    public abstract class PArrestedUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PARRESTEDID")]
		public virtual Anu.PunishmentOrg.ArrestSaftyWrit.PArrested? ThePArrested { get; set; }

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

    }
    [Table("PARRESTEDUNIT")]
    public partial class PArrestedUnit : PArrestedUnitBase { }

    }


