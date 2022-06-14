

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.WorkFlow.WFDefine
{
    public abstract class WFWorkflowEventCreateBase : BaseInfoEntity<string>
    {

		[Column("ACTIONTIME")]
		public virtual Anu.Enumerations.WorkFlowActionTime? ActionTime { get; set; }

		[ForeignKey("WFEVENTID")]
		public virtual Anu.WorkFlow.WFDefine.WFEvent? TheWFEvent { get; set; }

		[ForeignKey("WFWORKFLOWID")]
		public virtual Anu.WorkFlow.WFDefine.WFWorkflow? TheWFWorkflow { get; set; }

    }
    [Table("WFWORKFLOWEVENTCREATE")]
    public partial class WFWorkflowEventCreate : WFWorkflowEventCreateBase { }

    }


