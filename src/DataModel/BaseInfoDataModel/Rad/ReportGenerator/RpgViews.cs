

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgViewsBase : BaseInfoEntity<string>
    {

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("ISVISABLE4USER")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? IsVisable4User { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheSecondView")]
		public virtual List<Rad.ReportGenerator.RpgViewsRelationShip>? TheFirstViewsList { get; set; }

		[InverseProperty("TheRpgViews")]
		public virtual List<Rad.ReportGenerator.RpgViewAttributes>? TheRpgViewAttributesList { get; set; }

		[InverseProperty("TheFirstView")]
		public virtual List<Rad.ReportGenerator.RpgViewsRelationShip>? TheSecondViewsList { get; set; }

    }
    [Table("RPGVIEWS")]
    public partial class RpgViews : RpgViewsBase { }

    }


