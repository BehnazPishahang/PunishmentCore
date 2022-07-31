

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFWorkflowParameterBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("ENGLISHNAME")]
        public virtual string? EnglishName { get; set; }

        [Unicode(false)]
        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Column("PARAMTYPE")]
        public virtual Anu.BaseInfo.Enumerations.WFParameterType? ParamType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [ForeignKey("WFWORKFLOWID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflow? TheWFWorkflow { get; set; }

    }

    [Table("WFWORKFLOWPARAMETER")]
    public partial class WFWorkflowParameter : WFWorkflowParameterBase
    {
    }
    }