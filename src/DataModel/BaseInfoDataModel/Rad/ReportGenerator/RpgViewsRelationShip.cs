

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgViewsRelationShipBase : BaseInfoEntity<string>
    {

		[Column("FIRSTVIEWALIASFARSINAME")]
		public virtual string? FirstViewAliasFarsiName { get; set; }

		[Column("SECONDVIEWALIASFARSINAME")]
		public virtual string? SecondViewAliasFarsiName { get; set; }

		[ForeignKey("FIRSTVIEWID")]
		public virtual Rad.ReportGenerator.RpgViews? TheFirstView { get; set; }

		[InverseProperty("TheRpgViewsRelationShip")]
		public virtual List<Rad.ReportGenerator.RpgRelationAttributes>? TheRpgRelationAttributesList { get; set; }

		[ForeignKey("SECONDVIEWID")]
		public virtual Rad.ReportGenerator.RpgViews? TheSecondView { get; set; }

    }
    [Table("RPGVIEWSRELATIONSHIP")]
    public partial class RpgViewsRelationShip : RpgViewsRelationShipBase { }

    }


