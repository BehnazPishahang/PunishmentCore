

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Attachment
{
    public abstract class GAttachmentRelatedObjectBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectId { get; set; }

        [ForeignKey("GATTACHMENTID")]
        public virtual Anu.BaseInfo.DataModel.Attachment.GAttachment? TheGAttachment { get; set; }

        [ForeignKey("RELATEDFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedForm { get; set; }

        [ForeignKey("RELATEDSYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }

    [Table("GATTACHMENTRELATEDOBJECT")]
    public partial class GAttachmentRelatedObject : GAttachmentRelatedObjectBase
    {
    }
    }