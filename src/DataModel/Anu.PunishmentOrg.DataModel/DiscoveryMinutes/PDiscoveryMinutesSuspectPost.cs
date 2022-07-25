

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSuspectPostBase : PunishmentOrgEntity<string>
    {

        [Column("POSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PSuspectPostType? PostType { get; set; }

        [ForeignKey("PDISCOVERYMINUTESSUSPECTID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesSuspect? ThePDiscoveryMinutesSuspect { get; set; }

    }

    [Table("PDISCOVERYMINUTESSUSPECTPOST")]
    public partial class PDiscoveryMinutesSuspectPost : PDiscoveryMinutesSuspectPostBase
    {
    }
}