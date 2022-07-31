

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqSuspectTypBase : PunishmentOrgEntity<string>
    {

        [Column("LICENSEPERSONTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.LicensePersonType? LicensePersonType { get; set; }

        [ForeignKey("PCHASELICENSEREQSUSPECTID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqSuspect? ThePChaseLicenseReqSuspect { get; set; }

    }

    [Table("PCHASELICENSEREQSUSPECTTYP")]
    public partial class PChaseLicenseReqSuspectTyp : PChaseLicenseReqSuspectTypBase
    {
    }
    }