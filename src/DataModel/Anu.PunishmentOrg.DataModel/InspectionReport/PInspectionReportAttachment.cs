using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.Attachment;


namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportAttachmentBase : GAttachment
    {

        [ForeignKey("PINSPECTIONREPORTID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PINSPECTIONREPORTATTACHMENT")]
    public partial class PInspectionReportAttachment : PInspectionReportAttachmentBase
    {
    }
    }