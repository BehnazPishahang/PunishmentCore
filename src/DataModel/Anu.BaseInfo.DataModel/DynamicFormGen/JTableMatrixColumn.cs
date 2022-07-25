

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableMatrixColumnBase : BaseInfoEntity<string>
    {

        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("DISPLAYORDERNUMBER")]
        public virtual decimal? DisplayOrderNumber { get; set; }

        [Column("ISCOLUMNTOTAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsColumnTotal { get; set; }

        [Column("LENGTHCOLUMN")]
        public virtual decimal? LengthColumn { get; set; }

        [ForeignKey("HIGHLEVELITEMID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBItemTitle? TheHighLevelItem { get; set; }

        [ForeignKey("JBITEMTITLEID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBItemTitle? TheJBItemTitle { get; set; }

        [InverseProperty("TheJTableMatrixColumn")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableMatrixCell>? TheJTableMatrixCellList { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("JTABLEMATRIXCOLUMN")]
    public partial class JTableMatrixColumn : JTableMatrixColumnBase
    {
    }
}