

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFActivityEventFuncBase : BaseInfoEntity<string>
    {

        [Column("ACTIONTIME")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowActionTime? ActionTime { get; set; }

        [Column("ASSEMBLYNAME")]
        public virtual string? AssemblyName { get; set; }

        [Column("FUNCTIONFULLNAME")]
        public virtual string? FunctionFullName { get; set; }

        [Column("ROWNO")]
        public virtual long? RowNo { get; set; }

        [ForeignKey("WFACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivity? TheWFActivity { get; set; }

    }

    [Table("WFACTIVITYEVENTFUNC")]
    public partial class WFActivityEventFunc : WFActivityEventFuncBase
    {
    }
}