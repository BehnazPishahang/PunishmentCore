

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportFieldCalcsBase : BaseInfoEntity<string>
    {

		[ForeignKey("JBCALCFUNASSEMBLYID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

		[ForeignKey("JTABLEREPORTFIELDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

    }
    [Table("JTABLEREPORTFIELDCALCS")]
    public partial class JTableReportFieldCalcs : JTableReportFieldCalcsBase { }

    }


