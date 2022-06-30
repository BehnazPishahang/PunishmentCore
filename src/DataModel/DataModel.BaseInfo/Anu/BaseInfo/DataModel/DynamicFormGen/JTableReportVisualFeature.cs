

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportVisualFeatureBase : BaseInfoEntity<string>
    {

        [Column("ISBOLD")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsBold { get; set; }

        [Column("ISDISPLAYZEROMOSAVAB")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsDisplayZeroMosavab { get; set; }

        [Column("ISGRAYBACKGROUND")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsGrayBackground { get; set; }

        [Column("ISUNDERLINE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsUnderLine { get; set; }

        [Column("NULLROWTITLE")]
        public virtual string? NullRowTitle { get; set; }

        [Column("PRINTORDER")]
        public virtual decimal? PrintOrder { get; set; }

        [Column("REPORTTYPE")]
        public virtual Anu.BaseInfo.Enumerations.StaticReportType? ReportType { get; set; }

        [Column("ROWTYPE")]
        public virtual Anu.BaseInfo.Enumerations.StaticReportRowType? RowType { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

        [ForeignKey("JTABLEREPORTCOLUMNID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheJTableReportColumn { get; set; }

        [ForeignKey("JTABLEREPORTFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

    }

    [Table("JTABLEREPORTVISUALFEATURE")]
    public partial class JTableReportVisualFeature : JTableReportVisualFeatureBase
    {
    }
}