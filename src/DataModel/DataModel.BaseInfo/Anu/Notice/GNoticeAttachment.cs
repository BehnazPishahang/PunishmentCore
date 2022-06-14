

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Notice
{
    public abstract class GNoticeAttachmentBase : BaseInfoEntity<string>
    {

		[Column("ATTACHMENTDOCDATE")]
		public virtual string? AttachmentDocDate { get; set; }

		[Column("ATTACHMENTDOCNO")]
		public virtual string? AttachmentDocNo { get; set; }

		[Column("DOCFILE")]
		public virtual byte[]? DocFile { get; set; }

		[ForeignKey("ATTACHMENTTYPEID")]
		public virtual Anu.BaseInfo.Types.AttachmentType? TheAttachmentType { get; set; }

    }
    [Table("GNOTICEATTACHMENT")]
    public partial class GNoticeAttachment : GNoticeAttachmentBase { }

    }


