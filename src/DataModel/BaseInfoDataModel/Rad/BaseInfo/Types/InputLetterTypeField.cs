

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class InputLetterTypeFieldBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDFILEDDATATYPE")]
		public virtual Rad.CMS.Enumerations.ChangedFiledDataType? ChangedFiledDataType { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("COLUMNNAME")]
		public virtual string? ColumnName { get; set; }

		[Column("GROUP4LOOKUP")]
		public virtual string? Group4Lookup { get; set; }

		[Column("ISMANDATORY")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMandatory { get; set; }

		[ForeignKey("EXCHANGEFIELDBETWEENORGID")]
		public virtual Rad.BaseInfo.ExchangeData.ExchangeFieldBetweenOrg? TheExchangeFieldBetweenOrg { get; set; }

		[ForeignKey("INPUTLETTERTYPEID")]
		public virtual Rad.BaseInfo.Types.InputLetterType? TheInputLetterType { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("INPUTLETTERTYPEFIELD")]
    public partial class InputLetterTypeField : InputLetterTypeFieldBase { }

    }


