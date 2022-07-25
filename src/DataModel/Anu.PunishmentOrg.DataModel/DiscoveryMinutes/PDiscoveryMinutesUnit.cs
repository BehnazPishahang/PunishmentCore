

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }

    [Table("PDISCOVERYMINUTESUNIT")]
    public partial class PDiscoveryMinutesUnit : PDiscoveryMinutesUnitBase
    {
    }
}