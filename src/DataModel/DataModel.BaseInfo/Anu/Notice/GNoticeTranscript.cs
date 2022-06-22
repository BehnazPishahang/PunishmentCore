

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Notice
{
    public abstract class GNoticeTranscriptBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("SENDTYPE")]
		public virtual Anu.Enumerations.TranscriptSendType? SendType { get; set; }

		[ForeignKey("GNOTICEID")]
		public virtual Anu.Notice.GNotice? TheGNotice { get; set; }

		[Column("TRANSCRIPTTEXT")]
		public virtual string? TranscriptText { get; set; }

    }
    [Table("GNOTICETRANSCRIPT")]
    public partial class GNoticeTranscript : GNoticeTranscriptBase { }

    }


