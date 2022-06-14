

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class GNoticeTypeTranscriptBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("SENDTYPE")]
		public virtual Rad.CMS.Enumerations.TranscriptSendType? SendType { get; set; }

		[ForeignKey("GNOTICETYPEID")]
		public virtual Rad.BaseInfo.Types.GNoticeType? TheGNoticeType { get; set; }

		[Column("TRANSCRIPTTEXT")]
		public virtual string? TranscriptText { get; set; }

    }
    [Table("GNOTICETYPETRANSCRIPT")]
    public partial class GNoticeTypeTranscript : GNoticeTypeTranscriptBase { }

    }


