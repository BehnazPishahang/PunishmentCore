

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFActivityPerformerFuncBase : BaseInfoEntity<string>
    {

        [Column("ASSEMBLYNAME")]
        public virtual string? AssemblyName { get; set; }

        [Column("DESCRIPTOR")]
        public virtual string? Descriptor { get; set; }

        [Column("FUNCTIONFULLNAME")]
        public virtual string? FunctionFullName { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("WFACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivity? TheWFActivity { get; set; }

    }

    [Table("WFACTIVITYPERFORMERFUNC")]
    public partial class WFActivityPerformerFunc : WFActivityPerformerFuncBase
    {
    }
}