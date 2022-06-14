

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.WorkFlow.WFExec
{
    public abstract class WFInstanceBase : BaseInfoEntity<string>
    {

		[Column("IDPARAMVAL")]
		public virtual string? IDParamVal { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[InverseProperty("TheWFInstance")]
		public virtual List<Anu.WorkFlow.WFExec.WFACInstance>? TheWFACInstanceList { get; set; }

		[InverseProperty("TheWFInstance")]
		public virtual List<Anu.WorkFlow.WFExec.WFInstanceParamVal>? TheWFInstanceParamValList { get; set; }

		[ForeignKey("WFWORKFLOWID")]
		public virtual Anu.WorkFlow.WFDefine.WFWorkflow? TheWFWorkflow { get; set; }

    }
    [Table("WFINSTANCE")]
    public partial class WFInstance : WFInstanceBase { }

    }


