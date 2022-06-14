

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportColumnChgColumnsBase : BaseInfoEntity<string>
    {

		[ForeignKey("CHANGECOLUMNID")]
		public virtual Anu.DynamicFormGen.JTableReportColumn? TheChangeColumn { get; set; }

    }
    [Table("JTABLEREPORTCOLUMNCHGCOLUMNS")]
    public partial class JTableReportColumnChgColumns : JTableReportColumnChgColumnsBase { }

    }


