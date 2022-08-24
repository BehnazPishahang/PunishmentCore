using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportColumnCalcsBase : BaseInfoEntity<string>
    {

        [ForeignKey("JBCALCFUNASSEMBLYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

        [ForeignKey("JTABLEREPORTCOLUMNID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheJTableReportColumn { get; set; }

        }

    [Table("JTABLEREPORTCOLUMNCALCS")]
    public partial class JTableReportColumnCalcs : JTableReportColumnCalcsBase
    {
    }
    }