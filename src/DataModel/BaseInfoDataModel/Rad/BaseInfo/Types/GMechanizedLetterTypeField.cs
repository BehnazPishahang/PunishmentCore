

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class GMechanizedLetterTypeFieldBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDFILEDDATATYPE")]
		public virtual Rad.CMS.Enumerations.ChangedFiledDataType? ChangedFiledDataType { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("COURTTYPEACCESS")]
		public virtual string? CourtTypeAccess { get; set; }

		[Column("ISMANDATORY")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMandatory { get; set; }

		[Column("PRIORITY")]
		public virtual decimal? Priority { get; set; }

		[Column("RELATEDLETTER")]
		public virtual string? RelatedLetter { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("EXCHANGEFIELDBETWEENORGID")]
		public virtual Rad.BaseInfo.ExchangeData.ExchangeFieldBetweenOrg? TheExchangeFieldBetweenOrg { get; set; }

		[ForeignKey("GMECHANIZEDLETTERTYPEID")]
		public virtual Rad.BaseInfo.Types.GMechanizedLetterType? TheGMechanizedLetterType { get; set; }

		[ForeignKey("GMLETTERSERVICEID")]
		public virtual Rad.MechanizedLetter.GMLetterService? TheGMLetterService { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

    }
    [Table("GMECHANIZEDLETTERTYPEFIELD")]
    public partial class GMechanizedLetterTypeField : GMechanizedLetterTypeFieldBase { }

    }


