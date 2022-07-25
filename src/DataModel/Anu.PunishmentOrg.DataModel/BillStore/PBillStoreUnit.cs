

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BillStore
{
    public abstract class PBillStoreUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PBILLSTOREID")]
        public virtual Anu.PunishmentOrg.DataModel.BillStore.PBillStore? ThePBillStore { get; set; }

    }

    [Table("PBILLSTOREUNIT")]
    public partial class PBillStoreUnit : PBillStoreUnitBase
    {
    }
}