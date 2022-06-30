

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportFieldCalcsBase : BaseInfoEntity<string>
    {

        [ForeignKey("JBCALCFUNASSEMBLYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

        [ForeignKey("JTABLEREPORTFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

    }

    [Table("JTABLEREPORTFIELDCALCS")]
    public partial class JTableReportFieldCalcs : JTableReportFieldCalcsBase
    {
    }
}