

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.MechanizedLetter
{
    public abstract class GMechanizedLetterFieldsBase : BaseInfoEntity<string>
    {

		[Column("AMOUNT")]
		public virtual long? Amount { get; set; }

		[Column("ATTACHEDID")]
		public virtual string? AttachedId { get; set; }

		[Column("ATTACHMENTDESC")]
		public virtual string? AttachmentDesc { get; set; }

		[Column("DOCFILE")]
		public virtual byte[]? DocFile { get; set; }

		[Column("DOCFILEEXTENTION")]
		public virtual Anu.Enumerations.FileExtension? DocFileExtention { get; set; }

		[Column("FIELDDESC")]
		public virtual string? FieldDesc { get; set; }

		[Column("FILEDDATATYPE")]
		public virtual Anu.Enumerations.ChangedFiledDataType? FiledDataType { get; set; }

		[Column("TEXTAMOUNT")]
		public virtual string? TextAmount { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Anu.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[ForeignKey("GMECHANIZEDLETTERTYPEFIELDID")]
		public virtual Anu.BaseInfo.ExchangeData.GMechanizedLetterTypeField? TheGMechanizedLetterTypeField { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TURN")]
		public virtual long? Turn { get; set; }

    }
    [Table("GMECHANIZEDLETTERFIELDS")]
    public partial class GMechanizedLetterFields : GMechanizedLetterFieldsBase { }

    }


