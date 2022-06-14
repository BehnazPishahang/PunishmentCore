

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSuspectPostBase : PunishmentOrgEntity<string>
    {

		[Column("POSTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PSuspectPostType? PostType { get; set; }

		[ForeignKey("PDISCOVERYMINUTESSUSPECTID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesSuspect? ThePDiscoveryMinutesSuspect { get; set; }

    }
    [Table("PDISCOVERYMINUTESSUSPECTPOST")]
    public partial class PDiscoveryMinutesSuspectPost : PDiscoveryMinutesSuspectPostBase { }

    }


