

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestAttachmentBase : BaseInfoEntity<string>
    {

		[Column("ATTACHMENTDATE")]
		public virtual string? AttachmentDate { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("FILECONTENT")]
		public virtual byte[]? FileContent { get; set; }

		[Column("FILEEXTENTION")]
		public virtual string? FileExtention { get; set; }

		[ForeignKey("GATTACHMENTID")]
		public virtual Rad.Attachment.GAttachment? TheGAttachment { get; set; }

		[ForeignKey("GPROCESSATTACHMENTTYPEID")]
		public virtual Rad.BaseInfo.GProcess.GProcessAttachmentType? TheGProcessAttachmentType { get; set; }

		[ForeignKey("GREQUESTID")]
		public virtual Rad.BaseInfo.GProcess.GRequest? TheGRequest { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GREQUESTATTACHMENT")]
    public partial class GRequestAttachment : GRequestAttachmentBase { }

    }


