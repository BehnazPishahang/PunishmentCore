using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFActivityTransitionFuncBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ASSEMBLYNAME")]
        public virtual string? AssemblyName { get; set; }

        [Unicode(false)]
        [Column("FUNCTIONFULLNAME")]
        public virtual string? FunctionFullName { get; set; }

        [ForeignKey("WFACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivity? TheWFActivity { get; set; }

        }

    [Table("WFACTIVITYTRANSITIONFUNC")]
    public partial class WFActivityTransitionFunc : WFActivityTransitionFuncBase
    {
    }
    }