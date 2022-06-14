

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportVisualFeatureBase : BaseInfoEntity<string>
    {

		[Column("ISBOLD")]
		public virtual Anu.Enumerations.YesNo? IsBold { get; set; }

		[Column("ISDISPLAYZEROMOSAVAB")]
		public virtual Anu.Enumerations.YesNo? IsDisplayZeroMosavab { get; set; }

		[Column("ISGRAYBACKGROUND")]
		public virtual Anu.Enumerations.YesNo? IsGrayBackground { get; set; }

		[Column("ISUNDERLINE")]
		public virtual Anu.Enumerations.YesNo? IsUnderLine { get; set; }

		[Column("NULLROWTITLE")]
		public virtual string? NullRowTitle { get; set; }

		[Column("PRINTORDER")]
		public virtual decimal? PrintOrder { get; set; }

		[Column("REPORTTYPE")]
		public virtual Anu.Enumerations.StaticReportType? ReportType { get; set; }

		[Column("ROWTYPE")]
		public virtual Anu.Enumerations.StaticReportRowType? RowType { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual Anu.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

		[ForeignKey("JTABLEREPORTCOLUMNID")]
		public virtual Anu.DynamicFormGen.JTableReportColumn? TheJTableReportColumn { get; set; }

		[ForeignKey("JTABLEREPORTFIELDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

    }
    [Table("JTABLEREPORTVISUALFEATURE")]
    public partial class JTableReportVisualFeature : JTableReportVisualFeatureBase { }

    }


