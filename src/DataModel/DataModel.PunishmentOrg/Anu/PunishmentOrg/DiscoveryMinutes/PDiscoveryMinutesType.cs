

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesTypeBase : PunishmentOrgEntity<string>
    {

		[Column("PBDISCOVERYMINUTETYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PBDiscoveryMinutesType? PBDiscoveryMinuteType { get; set; }

		[ForeignKey("PDISCOVERYMINUTESID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }
    [Table("PDISCOVERYMINUTESTYPE")]
    public partial class PDiscoveryMinutesType : PDiscoveryMinutesTypeBase { }

    }


