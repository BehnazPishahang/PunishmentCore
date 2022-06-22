

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.WorkFlow.WFDefine
{
    public abstract class WFWorkflowParameterBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("PARAMTYPE")]
		public virtual Anu.Enumerations.WFParameterType? ParamType { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[ForeignKey("WFWORKFLOWID")]
		public virtual Anu.WorkFlow.WFDefine.WFWorkflow? TheWFWorkflow { get; set; }

    }
    [Table("WFWORKFLOWPARAMETER")]
    public partial class WFWorkflowParameter : WFWorkflowParameterBase { }

    }


