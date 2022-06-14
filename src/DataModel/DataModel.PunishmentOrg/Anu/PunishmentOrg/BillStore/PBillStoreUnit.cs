

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.BillStore
{
    public abstract class PBillStoreUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PBILLSTOREID")]
		public virtual Anu.PunishmentOrg.BillStore.PBillStore? ThePBillStore { get; set; }

    }
    [Table("PBILLSTOREUNIT")]
    public partial class PBillStoreUnit : PBillStoreUnitBase { }

    }


