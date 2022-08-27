using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JColumnTitleBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("COLUMNTITLE")]
        public virtual string? ColumnTitle { get; set; }

        [Column("LEVELORDER")]
        public virtual decimal? LevelOrder { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

        [ForeignKey("JTABLEREPORTPAGEANDGROUPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup? TheJTableReportPageAndGroup { get; set; }

        [InverseProperty("TheUpperColumn")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JColumnTitle>? TheLowerColumnsList { get; set; }

        [ForeignKey("UPPERCOLUMNID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JColumnTitle? TheUpperColumn { get; set; }

        }

    [Table("JCOLUMNTITLE")]
    public partial class JColumnTitle : JColumnTitleBase
    {
    }
    }