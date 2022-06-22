

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Accounting
{
    public abstract class PCashUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PCASHID")]
		public virtual Anu.PunishmentOrg.Accounting.PCash? ThePCash { get; set; }

    }
    [Table("PCASHUNIT")]
    public partial class PCashUnit : PCashUnitBase { }

    }


