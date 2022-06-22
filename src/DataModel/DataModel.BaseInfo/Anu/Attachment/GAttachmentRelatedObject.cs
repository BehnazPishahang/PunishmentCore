

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Attachment
{
    public abstract class GAttachmentRelatedObjectBase : BaseInfoEntity<string>
    {

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("GATTACHMENTID")]
		public virtual Anu.Attachment.GAttachment? TheGAttachment { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

		[ForeignKey("RELATEDSYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }
    [Table("GATTACHMENTRELATEDOBJECT")]
    public partial class GAttachmentRelatedObject : GAttachmentRelatedObjectBase { }

    }


