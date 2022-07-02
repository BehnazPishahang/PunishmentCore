

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesTypeBase : PunishmentOrgEntity<string>
    {

        [Column("PBDISCOVERYMINUTETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PBDiscoveryMinutesType? PBDiscoveryMinuteType { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }

    [Table("PDISCOVERYMINUTESTYPE")]
    public partial class PDiscoveryMinutesType : PDiscoveryMinutesTypeBase
    {
    }
}