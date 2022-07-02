

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BillStore
{
    public abstract class PBillStoreProductDiscoveryBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBILLSTOREPRODUCTID")]
        public virtual Anu.PunishmentOrg.DataModel.BillStore.PBillStoreProduct? ThePBillStoreProduct { get; set; }

        [ForeignKey("PDISCOVERYMINUTESPRODUCTFNDID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesProductFound? ThePDiscoveryMinutesProductFnd { get; set; }

    }

    [Table("PBILLSTOREPRODUCTDISCOVERY")]
    public partial class PBillStoreProductDiscovery : PBillStoreProductDiscoveryBase
    {
    }
}