using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSuspectHstBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("DOCDATE")]
        public virtual string? DocDate { get; set; }

        [Unicode(false)]
        [Column("DOCNO")]
        public virtual string? DocNo { get; set; }

        [ForeignKey("PDISCOVERYMINUTESSUSPECTID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesSuspect? ThePDiscoveryMinutesSuspect { get; set; }

        }

    [Table("PDISCOVERYMINUTESSUSPECTHST")]
    public partial class PDiscoveryMinutesSuspectHst : PDiscoveryMinutesSuspectHstBase
    {
    }
    }