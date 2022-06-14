

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgReportViewsRelAttBase : BaseInfoEntity<string>
    {

		[ForeignKey("FIRSTVIEWATTRIBUTEID")]
		public virtual Rad.ReportGenerator.RpgViewAttributes? TheFirstViewAttribute { get; set; }

		[ForeignKey("RPGREPORTVIEWSRELATIONID")]
		public virtual Rad.ReportGenerator.RpgReportViewsRelation? TheRpgReportViewsRelation { get; set; }

		[ForeignKey("SECONDVIEWATTRIBUTEID")]
		public virtual Rad.ReportGenerator.RpgViewAttributes? TheSecondViewAttribute { get; set; }

    }
    [Table("RPGREPORTVIEWSRELATT")]
    public partial class RpgReportViewsRelAtt : RpgReportViewsRelAttBase { }

    }


