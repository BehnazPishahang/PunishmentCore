

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableMatrixRowBase : BaseInfoEntity<string>
    {

        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("DISPLAYORDERNUMBER")]
        public virtual decimal? DisplayOrderNumber { get; set; }

        [Column("ISROWTOTAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsRowTotal { get; set; }

        [Column("LENGTHROW")]
        public virtual decimal? LengthRow { get; set; }

        [ForeignKey("HIGHLEVELITEMID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBItemTitle? TheHighLevelItem { get; set; }

        [ForeignKey("JBITEMTITLEID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBItemTitle? TheJBItemTitle { get; set; }

        [InverseProperty("TheJTableMatrixRow")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableMatrixCell>? TheJTableMatrixCellList { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("JTABLEMATRIXROW")]
    public partial class JTableMatrixRow : JTableMatrixRowBase
    {
    }
}