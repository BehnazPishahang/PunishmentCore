

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportColumnBase : BaseInfoEntity<string>
    {

		[Column("CSSCALSSNAMES")]
		public virtual string? CSSCalssNames { get; set; }

		[Column("DECIMALPOINTLENGTH")]
		public virtual decimal? DecimalPointLength { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DISPLAYMODE")]
		public virtual Anu.Enumerations.DisplayMode? DisplayMode { get; set; }

		[Column("DISPLAYORDERNUMBER")]
		public virtual decimal? DisplayOrderNumber { get; set; }

		[Column("HASDECIMALPOINT")]
		public virtual Anu.Enumerations.YesNo? HasDecimalPoint { get; set; }

		[Column("HOWCALCITEM")]
		public virtual Anu.Enumerations.HowCalcItem? HowCalcItem { get; set; }

		[Column("ISCOLUMNTOTAL")]
		public virtual Anu.Enumerations.YesNo? IsColumnTotal { get; set; }

		[Column("ISMANDATORY")]
		public virtual Anu.Enumerations.YesNo? IsMandatory { get; set; }

		[Column("ISUNIQUE")]
		public virtual Anu.Enumerations.YesNo? IsUnique { get; set; }

		[Column("ITEMTYPE")]
		public virtual Anu.Enumerations.TypeValue? ItemType { get; set; }

		[Column("LENGTHCOLUMN")]
		public virtual decimal? LengthColumn { get; set; }

		[Column("LOOKUPSHOWTYPE")]
		public virtual Anu.Enumerations.LookupShowType? LookupShowType { get; set; }

		[Column("LOOKUPWHERECOND")]
		public virtual string? LookupWhereCond { get; set; }

		[Column("MAXLENGTH")]
		public virtual decimal? MaxLength { get; set; }

		[Column("ORDERCALCNO")]
		public virtual decimal? OrderCalcNo { get; set; }

		[Column("ORDERCOLUMNNUMBER")]
		public virtual decimal? OrderColumnNumber { get; set; }

		[Column("SORTTYPE")]
		public virtual Anu.Enumerations.SortType? SortType { get; set; }

		[ForeignKey("JBCALCFUNASSEMBLYID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

		[ForeignKey("JBITEMTITLEID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBItemTitle? TheJBItemTitle { get; set; }

		[ForeignKey("JCOLUMNTITLEID")]
		public virtual Anu.DynamicFormGen.JColumnTitle? TheJColumnTitle { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual Anu.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

		[InverseProperty("TheJTableReportColumn")]
		public virtual List<Anu.DynamicFormGen.JTableReportColCondition>? TheJTableReportColConditionList { get; set; }

		[InverseProperty("TheMainColumn")]
		public virtual List<Anu.DynamicFormGen.JTableReportColMathCndExp>? TheJTableReportColMathCndExpList { get; set; }

		[InverseProperty("TheJTableReportColumn")]
		public virtual List<Anu.DynamicFormGen.JTableReportColumnCalcs>? TheJTableReportColumnCalcsList { get; set; }

		[ForeignKey("MAINCOLUMNID")]
		public virtual List<Anu.DynamicFormGen.JTableReportColumnChgColumns>? TheJTableReportColumnChgColumnsList { get; set; }

		[ForeignKey("JTABLEREPORTPAGEANDGROUPID")]
		public virtual Anu.DynamicFormGen.JTableReportPageAndGroup? TheJTableReportPageAndGroup { get; set; }

		[InverseProperty("TheJTableReportColumn")]
		public virtual List<Anu.DynamicFormGen.JTableReportVisualFeature>? TheJTableReportVisualFeatureList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("USEDINCALC")]
		public virtual Anu.Enumerations.YesNo? UsedInCalc { get; set; }

		[Column("VIEWCOLUMNNAME")]
		public virtual string? ViewColumnName { get; set; }

    }
    [Table("JTABLEREPORTCOLUMN")]
    public partial class JTableReportColumn : JTableReportColumnBase { }

    }


