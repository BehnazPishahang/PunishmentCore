

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ExchangeDataByLetter
{
    public abstract class GSendToJudiciaryFieldsBase : BaseInfoEntity<string>
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
		public virtual string? DocFileExtention { get; set; }

		[Column("FIELDDESC")]
		public virtual string? FieldDesc { get; set; }

		[Column("FILEDDATATYPE")]
		public virtual Rad.CMS.Enumerations.ChangedFiledDataType? FiledDataType { get; set; }

		[ForeignKey("GSENDTOJUDICIARYID")]
		public virtual Rad.ExchangeDataByLetter.GSendToJudiciary? TheGSendToJudiciary { get; set; }

		[ForeignKey("LETTERSUBJECTFIELDID")]
		public virtual Rad.BaseInfo.ExchangeData.LetterSubjectField? TheLetterSubjectField { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

		[ForeignKey("RELATEDOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedObject { get; set; }

		[Column("TURN")]
		public virtual decimal? Turn { get; set; }

    }
    [Table("GSENDTOJUDICIARYFIELDS")]
    public partial class GSendToJudiciaryFields : GSendToJudiciaryFieldsBase { }

    }


