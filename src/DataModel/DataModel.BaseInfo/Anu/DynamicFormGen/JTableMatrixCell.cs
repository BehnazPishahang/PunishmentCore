

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableMatrixCellBase : BaseInfoEntity<string>
    {

		[Column("CELLTYPE")]
		public virtual Anu.Enumerations.TypeValue? CellType { get; set; }

		[Column("ISMANDATORY")]
		public virtual Anu.Enumerations.YesNo? IsMandatory { get; set; }

		[Column("MAXLENGTH")]
		public virtual decimal? MaxLength { get; set; }

		[ForeignKey("JBSPECIFICDATAID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBSpecificData? TheJBSpecificData { get; set; }

		[ForeignKey("JTABLEMATRIXCOLUMNID")]
		public virtual Anu.DynamicFormGen.JTableMatrixColumn? TheJTableMatrixColumn { get; set; }

		[ForeignKey("JTABLEMATRIXROWID")]
		public virtual Anu.DynamicFormGen.JTableMatrixRow? TheJTableMatrixRow { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual Anu.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

    }
    [Table("JTABLEMATRIXCELL")]
    public partial class JTableMatrixCell : JTableMatrixCellBase { }

    }


