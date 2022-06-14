

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.BillStore
{
    public abstract class PBillStoreProductDiscoveryBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBILLSTOREPRODUCTID")]
		public virtual Anu.PunishmentOrg.BillStore.PBillStoreProduct? ThePBillStoreProduct { get; set; }

		[ForeignKey("PDISCOVERYMINUTESPRODUCTFNDID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesProductFound? ThePDiscoveryMinutesProductFnd { get; set; }

    }
    [Table("PBILLSTOREPRODUCTDISCOVERY")]
    public partial class PBillStoreProductDiscovery : PBillStoreProductDiscoveryBase { }

    }


