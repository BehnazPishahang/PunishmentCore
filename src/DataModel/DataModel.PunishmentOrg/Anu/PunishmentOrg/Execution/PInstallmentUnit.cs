

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PInstallmentUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PINSTALLMENTID")]
		public virtual Anu.PunishmentOrg.Execution.PInstallment? ThePInstallment { get; set; }

    }
    [Table("PINSTALLMENTUNIT")]
    public partial class PInstallmentUnit : PInstallmentUnitBase { }

    }


