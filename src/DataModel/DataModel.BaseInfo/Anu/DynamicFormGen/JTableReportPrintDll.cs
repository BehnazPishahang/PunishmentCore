

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportPrintDllBase : BaseInfoEntity<string>
    {

		[Column("PRINTORDER")]
		public virtual long? PrintOrder { get; set; }

		[InverseProperty("TheParentFunc")]
		public virtual List<Anu.DynamicFormGen.JTableReportPrintDll>? TheChildFuncsList { get; set; }

		[ForeignKey("JBDLLREGISTERID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

		[ForeignKey("PARENTFUNCID")]
		public virtual Anu.DynamicFormGen.JTableReportPrintDll? TheParentFunc { get; set; }

    }
    [Table("JTABLEREPORTPRINTDLL")]
    public partial class JTableReportPrintDll : JTableReportPrintDllBase { }

    }


