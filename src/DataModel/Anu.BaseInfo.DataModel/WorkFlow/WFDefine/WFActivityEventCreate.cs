using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFActivityEventCreateBase : BaseInfoEntity<string>
    {

        [Column("ACTIONTIME")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowActionTime? ActionTime { get; set; }

        [ForeignKey("WFACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivity? TheWFActivity { get; set; }

        [ForeignKey("WFEVENTID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFEvent? TheWFEvent { get; set; }

        }

    [Table("WFACTIVITYEVENTCREATE")]
    public partial class WFActivityEventCreate : WFActivityEventCreateBase
    {
    }
    }