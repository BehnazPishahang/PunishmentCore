

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportGrpRelationBase : BaseInfoEntity<string>
    {

		[ForeignKey("DETAILGRPID")]
		public virtual Anu.DynamicFormGen.JTableReportPageAndGroup? TheDetailGrp { get; set; }

		[ForeignKey("DETAILRELATIONCOLID")]
		public virtual Anu.DynamicFormGen.JTableReportColumn? TheDetailRelationCol { get; set; }

		[ForeignKey("MASTERGRPID")]
		public virtual Anu.DynamicFormGen.JTableReportPageAndGroup? TheMasterGrp { get; set; }

		[ForeignKey("MASTERRELATIONCOLID")]
		public virtual Anu.DynamicFormGen.JTableReportColumn? TheMasterRelationCol { get; set; }

		[ForeignKey("MASTERRELATIONFIELDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheMasterRelationField { get; set; }

    }
    [Table("JTABLEREPORTGRPRELATION")]
    public partial class JTableReportGrpRelation : JTableReportGrpRelationBase { }

    }


