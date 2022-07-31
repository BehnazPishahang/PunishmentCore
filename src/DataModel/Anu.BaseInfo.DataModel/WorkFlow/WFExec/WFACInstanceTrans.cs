

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFExec
{
    public abstract class WFACInstanceTransBase : BaseInfoEntity<string>
    {

        [ForeignKey("WFACINSTANCEID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFExec.WFACInstance? TheWFACInstance { get; set; }

        [ForeignKey("WFACTIVITYTRANSITIONID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivityTransition? TheWFActivityTransition { get; set; }

    }

    [Table("WFACINSTANCETRANS")]
    public partial class WFACInstanceTrans : WFACInstanceTransBase
    {
    }
    }