

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgRelationAttributesBase : BaseInfoEntity<string>
    {

		[ForeignKey("FIRSTVIEWATTRIBUTEID")]
		public virtual Rad.ReportGenerator.RpgViewAttributes? TheFirstViewAttribute { get; set; }

		[ForeignKey("RPGVIEWSRELATIONSHIPID")]
		public virtual Rad.ReportGenerator.RpgViewsRelationShip? TheRpgViewsRelationShip { get; set; }

		[ForeignKey("SECONDVIEWATTRIBUTEID")]
		public virtual Rad.ReportGenerator.RpgViewAttributes? TheSecondViewAttribute { get; set; }

    }
    [Table("RPGRELATIONATTRIBUTES")]
    public partial class RpgRelationAttributes : RpgRelationAttributesBase { }

    }


