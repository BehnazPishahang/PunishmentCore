

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportFieldValidatorBase : BaseInfoEntity<string>
    {

		[ForeignKey("JBDLLREGISTERID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

		[ForeignKey("JTABLEREPORTFIELDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

    }
    [Table("JTABLEREPORTFIELDVALIDATOR")]
    public partial class JTableReportFieldValidator : JTableReportFieldValidatorBase { }

    }


