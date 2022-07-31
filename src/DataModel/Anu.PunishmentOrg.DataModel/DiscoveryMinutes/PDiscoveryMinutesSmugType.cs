

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSmugTypeBase : PunishmentOrgEntity<string>
    {

        [Column("SMUGGLINGTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PSmuggling? SmugglingType { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }

    [Table("PDISCOVERYMINUTESSMUGTYPE")]
    public partial class PDiscoveryMinutesSmugType : PDiscoveryMinutesSmugTypeBase
    {
    }
    }