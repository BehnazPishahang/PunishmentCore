

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Individual
{
    public abstract class LegalPersonTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("GENERALTYPE")]
		public virtual Rad.CMS.Enumerations.LegalPersonType? GeneralType { get; set; }

		[Column("NATIONALCODEMANDATORY")]
		public virtual Rad.CMS.Enumerations.YesNo? NationalCodeMandatory { get; set; }

		[Column("REGISTERNOMANDATORY")]
		public virtual Rad.CMS.Enumerations.YesNo? RegisterNoMandatory { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheParentType")]
		public virtual List<Rad.BaseInfo.Individual.LegalPersonType>? TheChildTypeList { get; set; }

		[ForeignKey("PARENTTYPEID")]
		public virtual Rad.BaseInfo.Individual.LegalPersonType? TheParentType { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("LEGALPERSONTYPE")]
    public partial class LegalPersonType : LegalPersonTypeBase { }

    }


