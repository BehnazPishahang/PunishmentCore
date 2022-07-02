

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Notice
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
        public virtual Anu.BaseInfo.DataModel.Types.AttachmentType? TheAttachmentType { get; set; }

    }

    [Table("GNOTICEATTACHMENT")]
    public partial class GNoticeAttachment : GNoticeAttachmentBase
    {
    }
}