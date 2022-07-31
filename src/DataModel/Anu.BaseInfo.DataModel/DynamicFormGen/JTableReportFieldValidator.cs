

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportFieldValidatorBase : BaseInfoEntity<string>
    {

        [ForeignKey("JBDLLREGISTERID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

        [ForeignKey("JTABLEREPORTFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

    }

    [Table("JTABLEREPORTFIELDVALIDATOR")]
    public partial class JTableReportFieldValidator : JTableReportFieldValidatorBase
    {
    }
    }