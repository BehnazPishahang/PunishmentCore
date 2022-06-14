

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSuspectHstBase : PunishmentOrgEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DOCDATE")]
		public virtual string? DocDate { get; set; }

		[Column("DOCNO")]
		public virtual string? DocNo { get; set; }

		[ForeignKey("PDISCOVERYMINUTESSUSPECTID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesSuspect? ThePDiscoveryMinutesSuspect { get; set; }

    }
    [Table("PDISCOVERYMINUTESSUSPECTHST")]
    public partial class PDiscoveryMinutesSuspectHst : PDiscoveryMinutesSuspectHstBase { }

    }


