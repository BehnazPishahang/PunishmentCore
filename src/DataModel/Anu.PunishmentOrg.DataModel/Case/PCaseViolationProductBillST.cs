using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseViolationProductBillSTBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBILLSTOREPRODUCTID")]
        public virtual Anu.PunishmentOrg.DataModel.BillStore.PBillStoreProduct? ThePBillStoreProduct { get; set; }

        [ForeignKey("PCASEPRODUCTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseProduct? ThePCaseProduct { get; set; }

        }

    [Table("PCASEVIOLATIONPRODUCTBILLST")]
    public partial class PCaseViolationProductBillST : PCaseViolationProductBillSTBase
    {
    }
    }