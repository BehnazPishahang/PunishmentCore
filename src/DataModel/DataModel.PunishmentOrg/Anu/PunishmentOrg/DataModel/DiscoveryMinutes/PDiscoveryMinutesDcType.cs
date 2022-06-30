

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesDcTypeBase : PunishmentOrgEntity<string>
    {

        [Column("DISCOVERYTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PDiscoveryType? DiscoveryType { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }

    [Table("PDISCOVERYMINUTESDCTYPE")]
    public partial class PDiscoveryMinutesDcType : PDiscoveryMinutesDcTypeBase
    {
    }
}