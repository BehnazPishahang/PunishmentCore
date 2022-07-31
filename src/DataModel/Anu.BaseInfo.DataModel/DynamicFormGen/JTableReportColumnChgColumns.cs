

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportColumnChgColumnsBase : BaseInfoEntity<string>
    {

        [ForeignKey("CHANGECOLUMNID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheChangeColumn { get; set; }

    }

    [Table("JTABLEREPORTCOLUMNCHGCOLUMNS")]
    public partial class JTableReportColumnChgColumns : JTableReportColumnChgColumnsBase
    {
    }
    }