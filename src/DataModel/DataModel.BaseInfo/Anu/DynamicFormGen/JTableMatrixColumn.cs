

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableMatrixColumnBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DISPLAYORDERNUMBER")]
		public virtual decimal? DisplayOrderNumber { get; set; }

		[Column("ISCOLUMNTOTAL")]
		public virtual Anu.Enumerations.YesNo? IsColumnTotal { get; set; }

		[Column("LENGTHCOLUMN")]
		public virtual decimal? LengthColumn { get; set; }

		[ForeignKey("HIGHLEVELITEMID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBItemTitle? TheHighLevelItem { get; set; }

		[ForeignKey("JBITEMTITLEID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBItemTitle? TheJBItemTitle { get; set; }

		[InverseProperty("TheJTableMatrixColumn")]
		public virtual List<Anu.DynamicFormGen.JTableMatrixCell>? TheJTableMatrixCellList { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual Anu.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("JTABLEMATRIXCOLUMN")]
    public partial class JTableMatrixColumn : JTableMatrixColumnBase { }

    }


