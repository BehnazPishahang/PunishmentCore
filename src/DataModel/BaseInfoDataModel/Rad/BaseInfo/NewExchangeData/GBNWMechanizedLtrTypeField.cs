

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.NewExchangeData
{
    public abstract class GBNWMechanizedLtrTypeFieldBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDFILEDDATATYPE")]
		public virtual Rad.CMS.Enumerations.ChangedFiledDataType? ChangedFiledDataType { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ISMANDATORY")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMandatory { get; set; }

		[Column("MECHANIZEDFIELDTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizedFieldType? MechanizedFieldType { get; set; }

		[ForeignKey("GBNWMECHANIZEDLETTERTYPEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GBNWMechanizedLetterType? TheGBNWMechanizedLetterType { get; set; }

		[InverseProperty("TheGBNWMechanizedLtrTypeField")]
		public virtual List<Rad.BaseInfo.NewExchangeData.GBNWMechanizLtrTypFieldFrms>? TheGBNWMechanizLtrTypFieldFrmsList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GBNWMECHANIZEDLTRTYPEFIELD")]
    public partial class GBNWMechanizedLtrTypeField : GBNWMechanizedLtrTypeFieldBase { }

    }


