

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFActivityTransitionFuncBase : BaseInfoEntity<string>
    {

        [Column("ASSEMBLYNAME")]
        public virtual string? AssemblyName { get; set; }

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