

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBReportRelatedsBase : BaseInfoEntity<string>
    {

		[Column("RELATEDFORMAFFECT")]
		public virtual Anu.Enumerations.RelatedFormAffect? RelatedFormAffect { get; set; }

		[ForeignKey("MAINREPORTID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBReportTitle? TheMainReport { get; set; }

		[ForeignKey("RELATEDREPORTID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBReportTitle? TheRelatedReport { get; set; }

    }
    [Table("JBREPORTRELATEDS")]
    public partial class JBReportRelateds : JBReportRelatedsBase { }

    }


