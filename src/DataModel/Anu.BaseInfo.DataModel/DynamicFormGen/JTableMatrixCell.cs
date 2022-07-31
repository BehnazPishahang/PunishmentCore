

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableMatrixCellBase : BaseInfoEntity<string>
    {

        [Column("CELLTYPE")]
        public virtual Anu.BaseInfo.Enumerations.TypeValue? CellType { get; set; }

        [Column("ISMANDATORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsMandatory { get; set; }

        [Column("MAXLENGTH")]
        public virtual decimal? MaxLength { get; set; }

        [ForeignKey("JBSPECIFICDATAID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBSpecificData? TheJBSpecificData { get; set; }

        [ForeignKey("JTABLEMATRIXCOLUMNID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableMatrixColumn? TheJTableMatrixColumn { get; set; }

        [ForeignKey("JTABLEMATRIXROWID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableMatrixRow? TheJTableMatrixRow { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

    }

    [Table("JTABLEMATRIXCELL")]
    public partial class JTableMatrixCell : JTableMatrixCellBase
    {
    }
    }