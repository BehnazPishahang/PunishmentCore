

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSuspectVioBase : PunishmentOrgEntity<string>
    {

        [Column("OFFENDERINVOLVEDTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OffenderInvolvedType? OffenderInvolvedType { get; set; }

        [ForeignKey("PBVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

        [ForeignKey("PDISCOVERYMINUTESSUSPECTID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesSuspect? ThePDiscoveryMinutesSuspect { get; set; }

    }

    [Table("PDISCOVERYMINUTESSUSPECTVIO")]
    public partial class PDiscoveryMinutesSuspectVio : PDiscoveryMinutesSuspectVioBase
    {
    }
}