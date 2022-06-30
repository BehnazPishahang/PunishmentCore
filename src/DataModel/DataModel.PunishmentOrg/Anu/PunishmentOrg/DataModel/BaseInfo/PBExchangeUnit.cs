

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBExchangeUnitBase : PunishmentOrgEntity<string>
    {

        [Column("DISCOVERYUNITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryUnitType? DiscoveryUnitType { get; set; }

        [Column("ISPRODUCTKEEPER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsProductKeeper { get; set; }

    }

    [Table("PBEXCHANGEUNIT")]
    public partial class PBExchangeUnit : PBExchangeUnitBase
    {
    }
}