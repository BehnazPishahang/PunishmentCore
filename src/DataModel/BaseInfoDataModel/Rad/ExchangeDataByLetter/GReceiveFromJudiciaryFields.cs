

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ExchangeDataByLetter
{
    public abstract class GReceiveFromJudiciaryFieldsBase : BaseInfoEntity<string>
    {

		[Column("AMOUNT")]
		public virtual decimal? Amount { get; set; }

		[Column("DOCFILE")]
		public virtual byte[]? DocFile { get; set; }

		[Column("DOCFILEEXTENTION")]
		public virtual string? DocFileExtention { get; set; }

		[Column("FIELDDESC")]
		public virtual string? FieldDesc { get; set; }

		[Column("FILEDDATATYPE")]
		public virtual Rad.CMS.Enumerations.ChangedFiledDataType? FiledDataType { get; set; }

		[ForeignKey("GRECEIVEFROMJUDICIARYID")]
		public virtual Rad.ExchangeDataByLetter.GReceiveFromJudiciary? TheGReceiveFromJudiciary { get; set; }

		[ForeignKey("LETTERSUBJECTFIELDID")]
		public virtual Rad.BaseInfo.ExchangeData.LetterSubjectField? TheLetterSubjectField { get; set; }

		[Column("TURN")]
		public virtual decimal? Turn { get; set; }

    }
    [Table("GRECEIVEFROMJUDICIARYFIELDS")]
    public partial class GReceiveFromJudiciaryFields : GReceiveFromJudiciaryFieldsBase { }

    }


