

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseViolationProductBillSTBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBILLSTOREPRODUCTID")]
		public virtual Anu.PunishmentOrg.BillStore.PBillStoreProduct? ThePBillStoreProduct { get; set; }

		[ForeignKey("PCASEPRODUCTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseProduct? ThePCaseProduct { get; set; }

    }
    [Table("PCASEVIOLATIONPRODUCTBILLST")]
    public partial class PCaseViolationProductBillST : PCaseViolationProductBillSTBase { }

    }


