

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.WorkFlow.WFDefine
{
    public abstract class WFWorkflowBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("INVALIDDATETIME")]
		public virtual string? InValidDateTime { get; set; }

		[Column("SERIALIZEDGRAPH")]
		public virtual byte[]? SerializedGraph { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.WFDefinitionState? State { get; set; }

		[InverseProperty("TheWFWorkflow")]
		public virtual List<Anu.WorkFlow.WFDefine.WFActivity>? TheWFActivityList { get; set; }

		[ForeignKey("WFPREVIOUSVERSIONID")]
		public virtual Anu.WorkFlow.WFDefine.WFWorkflow? TheWFPreviousVersion { get; set; }

		[InverseProperty("TheWFWorkflow")]
		public virtual List<Anu.WorkFlow.WFDefine.WFWorkflowEventCreate>? TheWFWorkflowEventCreateList { get; set; }

		[InverseProperty("TheWFWorkflow")]
		public virtual List<Anu.WorkFlow.WFDefine.WFWorkflowEventFunc>? TheWFWorkflowEventFuncList { get; set; }

		[InverseProperty("TheWFWorkflow")]
		public virtual List<Anu.WorkFlow.WFDefine.WFWorkflowParameter>? TheWFWorkflowParameterList { get; set; }

		[Column("VALIDDATETIME")]
		public virtual string? ValidDateTime { get; set; }

		[Column("VERSIONNUMBER")]
		public virtual long? VersionNumber { get; set; }

    }
    [Table("WFWORKFLOW")]
    public partial class WFWorkflow : WFWorkflowBase { }

    }


