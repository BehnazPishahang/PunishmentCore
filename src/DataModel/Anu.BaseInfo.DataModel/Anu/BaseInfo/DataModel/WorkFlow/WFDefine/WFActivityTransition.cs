

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFActivityTransitionBase : BaseInfoEntity<string>
    {

        [ForeignKey("CURRENTACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivity? TheCurrentActivity { get; set; }

        [ForeignKey("NEXTACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivity? TheNextActivity { get; set; }

    }

    [Table("WFACTIVITYTRANSITION")]
    public partial class WFActivityTransition : WFActivityTransitionBase
    {
    }
}