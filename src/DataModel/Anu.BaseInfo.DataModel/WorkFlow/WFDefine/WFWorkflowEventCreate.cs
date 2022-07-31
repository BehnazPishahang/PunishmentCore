

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFWorkflowEventCreateBase : BaseInfoEntity<string>
    {

        [Column("ACTIONTIME")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowActionTime? ActionTime { get; set; }

        [ForeignKey("WFEVENTID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFEvent? TheWFEvent { get; set; }

        [ForeignKey("WFWORKFLOWID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflow? TheWFWorkflow { get; set; }

    }

    [Table("WFWORKFLOWEVENTCREATE")]
    public partial class WFWorkflowEventCreate : WFWorkflowEventCreateBase
    {
    }
    }