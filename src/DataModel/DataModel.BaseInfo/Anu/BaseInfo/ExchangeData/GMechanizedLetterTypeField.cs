

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.ExchangeData
{
    public abstract class GMechanizedLetterTypeFieldBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDFILEDDATATYPE")]
		public virtual Anu.Enumerations.ChangedFiledDataType? ChangedFiledDataType { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ISMANDATORY")]
		public virtual Anu.Enumerations.YesNo? IsMandatory { get; set; }

		[Column("MECHANIZEDFIELDTYPE")]
		public virtual Anu.Enumerations.MechanizedFieldType? MechanizedFieldType { get; set; }

		[ForeignKey("GMECHANIZEDLETTERTYPEID")]
		public virtual Anu.BaseInfo.ExchangeData.GMechanizedLetterType? TheGMechanizedLetterType { get; set; }

		[InverseProperty("TheGMechanizedLetterTypeField")]
		public virtual List<Anu.BaseInfo.ExchangeData.GMechanizLtrTypeFieldForms>? TheGMechanizLtrTypeFieldFormsList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GMECHANIZEDLETTERTYPEFIELD")]
    public partial class GMechanizedLetterTypeField : GMechanizedLetterTypeFieldBase { }

    }


