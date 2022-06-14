

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Attachment
{
    public abstract class GAttachmentRelatedObjectBase : BaseInfoEntity<string>
    {

		[Column("DELETETIME")]
		public virtual string? DeleteTime { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("GATTACHMENTID")]
		public virtual Rad.Attachment.GAttachment? TheGAttachment { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

		[ForeignKey("RELATEDSYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }
    [Table("GATTACHMENTRELATEDOBJECT")]
    public partial class GAttachmentRelatedObject : GAttachmentRelatedObjectBase { }

    }


