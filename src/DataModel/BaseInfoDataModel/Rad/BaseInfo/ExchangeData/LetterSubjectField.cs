

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.ExchangeData
{
    public abstract class LetterSubjectFieldBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDFILEDDATATYPE")]
		public virtual Rad.CMS.Enumerations.ChangedFiledDataType? ChangedFiledDataType { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("COURTTYPEACCESS")]
		public virtual string? CourtTypeAccess { get; set; }

		[Column("ISMANDATORY")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMandatory { get; set; }

		[ForeignKey("EXCHANGEFIELDBETWEENORGID")]
		public virtual Rad.BaseInfo.ExchangeData.ExchangeFieldBetweenOrg? TheExchangeFieldBetweenOrg { get; set; }

		[ForeignKey("LETTERSUBJECTBETWEENORGTYPEID")]
		public virtual Rad.BaseInfo.ExchangeData.LetterSubjectBetweenOrgType? TheLetterSubjectBetweenOrgType { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual Rad.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

    }
    [Table("LETTERSUBJECTFIELD")]
    public partial class LetterSubjectField : LetterSubjectFieldBase { }

    }


