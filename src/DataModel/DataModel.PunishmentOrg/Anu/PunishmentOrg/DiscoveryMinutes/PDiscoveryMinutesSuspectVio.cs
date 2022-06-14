

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSuspectVioBase : PunishmentOrgEntity<string>
    {

		[Column("OFFENDERINVOLVEDTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.OffenderInvolvedType? OffenderInvolvedType { get; set; }

		[ForeignKey("PBVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBViolationType? ThePBViolationType { get; set; }

		[ForeignKey("PDISCOVERYMINUTESSUSPECTID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesSuspect? ThePDiscoveryMinutesSuspect { get; set; }

    }
    [Table("PDISCOVERYMINUTESSUSPECTVIO")]
    public partial class PDiscoveryMinutesSuspectVio : PDiscoveryMinutesSuspectVioBase { }

    }


