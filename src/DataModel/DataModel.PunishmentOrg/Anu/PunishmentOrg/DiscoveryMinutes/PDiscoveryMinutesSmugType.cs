

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSmugTypeBase : PunishmentOrgEntity<string>
    {

		[Column("SMUGGLINGTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PSmuggling? SmugglingType { get; set; }

		[ForeignKey("PDISCOVERYMINUTESID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }
    [Table("PDISCOVERYMINUTESSMUGTYPE")]
    public partial class PDiscoveryMinutesSmugType : PDiscoveryMinutesSmugTypeBase { }

    }


