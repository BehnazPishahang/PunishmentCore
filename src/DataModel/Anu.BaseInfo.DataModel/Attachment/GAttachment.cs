

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Attachment
{
    public abstract class GAttachmentBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ATTACHMENTDOCDATE")]
        public virtual string? AttachmentDocDate { get; set; }

        [Unicode(false)]
        [Column("ATTACHMENTDOCNO")]
        public virtual string? AttachmentDocNo { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("FILEEXTENSION")]
        public virtual Anu.BaseInfo.Enumerations.FileExtension? FileExtension { get; set; }

        [Column("ORDERNO")]
        public virtual long? OrderNo { get; set; }

        [Unicode(false)]
        [Column("OTHERDATA")]
        public virtual string? OtherData { get; set; }

        [Column("PAGENUM")]
        public virtual long? PageNum { get; set; }

        [Unicode(false)]
        [Column("PATHANDFILENAME")]
        public virtual string? PathAndFileName { get; set; }

        [Column("PROCESSSTATE")]
        public virtual Anu.BaseInfo.Enumerations.AttachmentProcessState? ProcessState { get; set; }

        [Column("SAVEATTACHMENTTYPE")]
        public virtual Anu.BaseInfo.Enumerations.SaveAttachmentType? SaveAttachmentType { get; set; }

        [Unicode(false)]
        [Column("SECONDMILI")]
        public virtual string? SecondMili { get; set; }

        [ForeignKey("ATTACHMENTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.AttachmentType? TheAttachmentType { get; set; }

        [ForeignKey("GATTACHMENTDATAID")]
        public virtual Anu.BaseInfo.DataModel.Attachment.GAttachmentData? TheGAttachmentData { get; set; }

        [InverseProperty("TheGAttachment")]
        public virtual List<Anu.BaseInfo.DataModel.Attachment.GAttachmentRelatedObject>? TheGAttachmentRelatedObjectList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GATTACHMENT")]
    public partial class GAttachment : GAttachmentBase
    {
    }
    }