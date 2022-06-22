

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JColumnTitleBase : BaseInfoEntity<string>
    {

		[Column("COLUMNTITLE")]
		public virtual string? ColumnTitle { get; set; }

		[Column("LEVELORDER")]
		public virtual decimal? LevelOrder { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual Anu.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

		[ForeignKey("JTABLEREPORTPAGEANDGROUPID")]
		public virtual Anu.DynamicFormGen.JTableReportPageAndGroup? TheJTableReportPageAndGroup { get; set; }

		[InverseProperty("TheUpperColumn")]
		public virtual List<Anu.DynamicFormGen.JColumnTitle>? TheLowerColumnsList { get; set; }

		[ForeignKey("UPPERCOLUMNID")]
		public virtual Anu.DynamicFormGen.JColumnTitle? TheUpperColumn { get; set; }

    }
    [Table("JCOLUMNTITLE")]
    public partial class JColumnTitle : JColumnTitleBase { }

    }


