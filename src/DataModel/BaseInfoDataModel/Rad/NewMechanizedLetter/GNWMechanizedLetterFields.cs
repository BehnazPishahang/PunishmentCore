

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.NewMechanizedLetter
{
    public abstract class GNWMechanizedLetterFieldsBase : BaseInfoEntity<string>
    {

		[Column("AMOUNT")]
		public virtual decimal? Amount { get; set; }

		[Column("ATTACHEDID")]
		public virtual string? AttachedId { get; set; }

		[Column("ATTACHMENTDESC")]
		public virtual string? AttachmentDesc { get; set; }

		[Column("DOCFILE")]
		public virtual byte[]? DocFile { get; set; }

		[Column("DOCFILEEXTENTION")]
		public virtual Rad.CMS.Enumerations.FileExtension? DocFileExtention { get; set; }

		[Column("FIELDDESC")]
		public virtual string? FieldDesc { get; set; }

		[Column("FILEDDATATYPE")]
		public virtual Rad.CMS.Enumerations.ChangedFiledDataType? FiledDataType { get; set; }

		[Column("FILESAVETYPE")]
		public virtual Rad.CMS.Enumerations.SaveAttachmentType? FileSaveType { get; set; }

		[Column("PATHANDFILENAME")]
		public virtual string? PathAndFileName { get; set; }

		[Column("TEXTAMOUNT")]
		public virtual string? TextAmount { get; set; }

		[ForeignKey("GBNWMECHANIZEDLTRTYPEFIELDID")]
		public virtual Rad.BaseInfo.NewExchangeData.GBNWMechanizedLtrTypeField? TheGBNWMechanizedLtrTypeField { get; set; }

		[ForeignKey("GNWMECHANIZEDLETTERID")]
		public virtual Rad.NewMechanizedLetter.GNWMechanizedLetter? TheGNWMechanizedLetter { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TURN")]
		public virtual decimal? Turn { get; set; }

    }
    [Table("GNWMECHANIZEDLETTERFIELDS")]
    public partial class GNWMechanizedLetterFields : GNWMechanizedLetterFieldsBase { }

    }


