

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Attachment
{
    public abstract class GAttachmentBase : BaseInfoEntity<string>
    {

		[Column("ATTACHMENTDOCDATE")]
		public virtual string? AttachmentDocDate { get; set; }

		[Column("ATTACHMENTDOCNO")]
		public virtual string? AttachmentDocNo { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("FILEEXTENSION")]
		public virtual Rad.CMS.Enumerations.FileExtension? FileExtension { get; set; }

		[Column("ORDERNO")]
		public virtual decimal? OrderNo { get; set; }

		[Column("OTHERDATA")]
		public virtual string? OtherData { get; set; }

		[Column("PAGENUM")]
		public virtual long? PageNum { get; set; }

		[Column("PATHANDFILENAME")]
		public virtual string? PathAndFileName { get; set; }

		[Column("PROCESSSTATE")]
		public virtual Rad.CMS.Enumerations.AttachmentProcessState? ProcessState { get; set; }

		[Column("SAVEATTACHMENTTYPE")]
		public virtual Rad.CMS.Enumerations.SaveAttachmentType? SaveAttachmentType { get; set; }

		[Column("SECONDMILI")]
		public virtual string? SecondMili { get; set; }

		[ForeignKey("AIATTACHMENTTYPEID")]
		public virtual Rad.BaseInfo.Types.AttachmentType? TheAIAttachmentType { get; set; }

		[ForeignKey("ATTACHMENTTYPEID")]
		public virtual Rad.BaseInfo.Types.AttachmentType? TheAttachmentType { get; set; }

		[ForeignKey("GATTACHMENTDATAID")]
		public virtual Rad.Attachment.GAttachmentData? TheGAttachmentData { get; set; }

		[InverseProperty("TheGAttachment")]
		public virtual List<Rad.Attachment.GAttachmentRelatedObject>? TheGAttachmentRelatedObjectList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("VOLUME")]
		public virtual string? Volume { get; set; }

    }
    [Table("GATTACHMENT")]
    public partial class GAttachment : GAttachmentBase { }

    }


