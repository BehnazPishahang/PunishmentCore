

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Accounting
{
    public abstract class PBill4PaidUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PBILL4PAIDID")]
		public virtual Anu.PunishmentOrg.Accounting.PBill4Paid? ThePBill4Paid { get; set; }

    }
    [Table("PBILL4PAIDUNIT")]
    public partial class PBill4PaidUnit : PBill4PaidUnitBase { }

    }


