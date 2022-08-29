using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Notice
{
    public abstract class GNoticeTranscriptBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("SENDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.TranscriptSendType? SendType { get; set; }

        [ForeignKey("GNOTICEID")]
        public virtual Anu.BaseInfo.DataModel.Notice.GNotice? TheGNotice { get; set; }

        [Unicode(false)]
        [Column("TRANSCRIPTTEXT")]
        public virtual string? TranscriptText { get; set; }

        }

    [Table("GNOTICETRANSCRIPT")]
    public partial class GNoticeTranscript : GNoticeTranscriptBase
    {
    }
    }