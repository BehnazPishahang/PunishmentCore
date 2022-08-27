using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.PunishmentOrg.DataModel.DiscoveryMinutes;


namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqSuspectTypBase : PChaseLicenseReqObject
    {

        [Column("LICENSEPERSONTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.LicensePersonType? LicensePersonType { get; set; }

        [ForeignKey("PCHASELICENSEREQSUSPECTID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqSuspect? ThePChaseLicenseReqSuspect { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PCHASELICENSEREQSUSPECTTYP")]
    public partial class PChaseLicenseReqSuspectTyp : PChaseLicenseReqSuspectTypBase
    {
    }
    }