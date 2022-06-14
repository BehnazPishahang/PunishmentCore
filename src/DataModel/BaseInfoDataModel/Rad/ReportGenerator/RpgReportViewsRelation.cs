

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgReportViewsRelationBase : BaseInfoEntity<string>
    {

		[ForeignKey("FIRSTVIEWID")]
		public virtual Rad.ReportGenerator.RpgReportViews? TheFirstView { get; set; }

		[InverseProperty("TheRpgReportViewsRelation")]
		public virtual List<Rad.ReportGenerator.RpgReportViewsRelAtt>? TheRpgReportViewsRelAttList { get; set; }

		[ForeignKey("SECONDVIEWID")]
		public virtual Rad.ReportGenerator.RpgReportViews? TheSecondView { get; set; }

    }
    [Table("RPGREPORTVIEWSRELATION")]
    public partial class RpgReportViewsRelation : RpgReportViewsRelationBase { }

    }


