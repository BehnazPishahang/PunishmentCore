

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.WorkFlow.WFDefine
{
    public abstract class WFActivityEventFuncBase : BaseInfoEntity<string>
    {

		[Column("ACTIONTIME")]
		public virtual Anu.Enumerations.WorkFlowActionTime? ActionTime { get; set; }

		[Column("ASSEMBLYNAME")]
		public virtual string? AssemblyName { get; set; }

		[Column("FUNCTIONFULLNAME")]
		public virtual string? FunctionFullName { get; set; }

		[Column("ROWNO")]
		public virtual long? RowNo { get; set; }

		[ForeignKey("WFACTIVITYID")]
		public virtual Anu.WorkFlow.WFDefine.WFActivity? TheWFActivity { get; set; }

    }
    [Table("WFACTIVITYEVENTFUNC")]
    public partial class WFActivityEventFunc : WFActivityEventFuncBase { }

    }


