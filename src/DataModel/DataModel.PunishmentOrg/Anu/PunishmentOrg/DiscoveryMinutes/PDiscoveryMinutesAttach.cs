

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesAttachBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PDISCOVERYMINUTESID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }
    [Table("PDISCOVERYMINUTESATTACH")]
    public partial class PDiscoveryMinutesAttach : PDiscoveryMinutesAttachBase { }

    }


