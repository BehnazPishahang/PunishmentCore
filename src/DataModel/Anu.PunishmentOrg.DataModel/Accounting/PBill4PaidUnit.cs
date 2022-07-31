

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PBill4PaidUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PBILL4PAIDID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PBill4Paid? ThePBill4Paid { get; set; }

    }

    [Table("PBILL4PAIDUNIT")]
    public partial class PBill4PaidUnit : PBill4PaidUnitBase
    {
    }
    }