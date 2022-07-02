

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
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
        public virtual Anu.BaseInfo.Enumerations.DisplayMode? DisplayMode { get; set; }

        [Column("DISPLAYORDERNUMBER")]
        public virtual decimal? DisplayOrderNumber { get; set; }

        [Column("HASDECIMALPOINT")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? HasDecimalPoint { get; set; }

        [Column("HOWCALCITEM")]
        public virtual Anu.BaseInfo.Enumerations.HowCalcItem? HowCalcItem { get; set; }

        [Column("ISCOLUMNTOTAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsColumnTotal { get; set; }

        [Column("ISMANDATORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsMandatory { get; set; }

        [Column("ISUNIQUE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsUnique { get; set; }

        [Column("ITEMTYPE")]
        public virtual Anu.BaseInfo.Enumerations.TypeValue? ItemType { get; set; }

        [Column("LENGTHCOLUMN")]
        public virtual decimal? LengthColumn { get; set; }

        [Column("LOOKUPSHOWTYPE")]
        public virtual Anu.BaseInfo.Enumerations.LookupShowType? LookupShowType { get; set; }

        [Column("LOOKUPWHERECOND")]
        public virtual string? LookupWhereCond { get; set; }

        [Column("MAXLENGTH")]
        public virtual decimal? MaxLength { get; set; }

        [Column("ORDERCALCNO")]
        public virtual decimal? OrderCalcNo { get; set; }

        [Column("ORDERCOLUMNNUMBER")]
        public virtual decimal? OrderColumnNumber { get; set; }

        [Column("SORTTYPE")]
        public virtual Anu.BaseInfo.Enumerations.SortType? SortType { get; set; }

        [ForeignKey("JBCALCFUNASSEMBLYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

        [ForeignKey("JBITEMTITLEID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBItemTitle? TheJBItemTitle { get; set; }

        [ForeignKey("JCOLUMNTITLEID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JColumnTitle? TheJColumnTitle { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

        [InverseProperty("TheJTableReportColumn")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColCondition>? TheJTableReportColConditionList { get; set; }

        [InverseProperty("TheMainColumn")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColMathCndExp>? TheJTableReportColMathCndExpList { get; set; }

        [InverseProperty("TheJTableReportColumn")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumnCalcs>? TheJTableReportColumnCalcsList { get; set; }

        [ForeignKey("MAINCOLUMNID")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumnChgColumns>? TheJTableReportColumnChgColumnsList { get; set; }

        [ForeignKey("JTABLEREPORTPAGEANDGROUPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup? TheJTableReportPageAndGroup { get; set; }

        [InverseProperty("TheJTableReportColumn")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportVisualFeature>? TheJTableReportVisualFeatureList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("USEDINCALC")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? UsedInCalc { get; set; }

        [Column("VIEWCOLUMNNAME")]
        public virtual string? ViewColumnName { get; set; }

    }

    [Table("JTABLEREPORTCOLUMN")]
    public partial class JTableReportColumn : JTableReportColumnBase
    {
    }
}