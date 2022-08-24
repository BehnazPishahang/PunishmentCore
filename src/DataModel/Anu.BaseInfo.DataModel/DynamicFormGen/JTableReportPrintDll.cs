using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportPrintDllBase : BaseInfoEntity<string>
    {

        [Column("PRINTORDER")]
        public virtual long? PrintOrder { get; set; }

        [InverseProperty("TheParentFunc")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPrintDll>? TheChildFuncsList { get; set; }

        [ForeignKey("JBDLLREGISTERID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

        [ForeignKey("PARENTFUNCID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPrintDll? TheParentFunc { get; set; }

        }

    [Table("JTABLEREPORTPRINTDLL")]
    public partial class JTableReportPrintDll : JTableReportPrintDllBase
    {
    }
    }