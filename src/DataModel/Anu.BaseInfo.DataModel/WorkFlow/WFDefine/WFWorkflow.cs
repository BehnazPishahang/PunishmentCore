

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFWorkflowBase : BaseInfoEntity<string>
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

        [Unicode(false)]
        [Column("INVALIDDATETIME")]
        public virtual string? InValidDateTime { get; set; }

        [Column("SERIALIZEDGRAPH")]
        public virtual byte[]? SerializedGraph { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.WFDefinitionState? State { get; set; }

        [InverseProperty("TheWFWorkflow")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivity>? TheWFActivityList { get; set; }

        [ForeignKey("WFPREVIOUSVERSIONID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflow? TheWFPreviousVersion { get; set; }

        [InverseProperty("TheWFWorkflow")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflowEventCreate>? TheWFWorkflowEventCreateList { get; set; }

        [InverseProperty("TheWFWorkflow")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflowEventFunc>? TheWFWorkflowEventFuncList { get; set; }

        [InverseProperty("TheWFWorkflow")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflowParameter>? TheWFWorkflowParameterList { get; set; }

        [Unicode(false)]
        [Column("VALIDDATETIME")]
        public virtual string? ValidDateTime { get; set; }

        [Column("VERSIONNUMBER")]
        public virtual long? VersionNumber { get; set; }

    }

    [Table("WFWORKFLOW")]
    public partial class WFWorkflow : WFWorkflowBase
    {
    }
    }