using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.Attachment;


namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PReportViolationAttachBase : GAttachment
    {

        [ForeignKey("PREPORTVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PREPORTVIOLATIONATTACH")]
    public partial class PReportViolationAttach : PReportViolationAttachBase
    {
    }
    }