

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesDcTypeBase : PunishmentOrgEntity<string>
    {

		[Column("DISCOVERYTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PDiscoveryType? DiscoveryType { get; set; }

		[ForeignKey("PDISCOVERYMINUTESID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }
    [Table("PDISCOVERYMINUTESDCTYPE")]
    public partial class PDiscoveryMinutesDcType : PDiscoveryMinutesDcTypeBase { }

    }


