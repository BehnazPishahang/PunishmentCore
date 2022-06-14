

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqSuspectTypBase : PunishmentOrgEntity<string>
    {

		[Column("LICENSEPERSONTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.LicensePersonType? LicensePersonType { get; set; }

		[ForeignKey("PCHASELICENSEREQSUSPECTID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqSuspect? ThePChaseLicenseReqSuspect { get; set; }

    }
    [Table("PCHASELICENSEREQSUSPECTTYP")]
    public partial class PChaseLicenseReqSuspectTyp : PChaseLicenseReqSuspectTypBase { }

    }


