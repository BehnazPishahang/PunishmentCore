

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportColumnCalcsBase : BaseInfoEntity<string>
    {

		[ForeignKey("JBCALCFUNASSEMBLYID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

		[ForeignKey("JTABLEREPORTCOLUMNID")]
		public virtual Anu.DynamicFormGen.JTableReportColumn? TheJTableReportColumn { get; set; }

    }
    [Table("JTABLEREPORTCOLUMNCALCS")]
    public partial class JTableReportColumnCalcs : JTableReportColumnCalcsBase { }

    }


