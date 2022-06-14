

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.WorkFlow.WFDefine
{
    public abstract class WFActivityBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DELETEFROMDIAGRAM")]
		public virtual Anu.Enumerations.YesNo? DeleteFromDiagram { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("MAXDELAYTIME")]
		public virtual long? MaxDelayTime { get; set; }

		[Column("STEPBACKABLE")]
		public virtual Anu.Enumerations.YesNo? StepBackable { get; set; }

		[ForeignKey("BASEROLEID")]
		public virtual Anu.BaseInfo.Security.Role.BaseRole? TheBaseRole { get; set; }

		[InverseProperty("TheNextActivity")]
		public virtual List<Anu.WorkFlow.WFDefine.WFActivityTransition>? TheCurrentActivitiesTransList { get; set; }

		[InverseProperty("TheCurrentActivity")]
		public virtual List<Anu.WorkFlow.WFDefine.WFActivityTransition>? TheNextActivitiesTransList { get; set; }

		[InverseProperty("TheWFActivity")]
		public virtual List<Anu.WorkFlow.WFDefine.WFActivityEventCreate>? TheWFActivityEventCreateList { get; set; }

		[InverseProperty("TheWFActivity")]
		public virtual List<Anu.WorkFlow.WFDefine.WFActivityEventFunc>? TheWFActivityEventFuncList { get; set; }

		[InverseProperty("TheWFActivity")]
		public virtual List<Anu.WorkFlow.WFDefine.WFActivityParameter>? TheWFActivityParameterList { get; set; }

		[ForeignKey("WFWORKFLOWID")]
		public virtual Anu.WorkFlow.WFDefine.WFWorkflow? TheWFWorkflow { get; set; }

		[Column("TOTALINPUT")]
		public virtual long? TotalInput { get; set; }

		[Column("TYPE")]
		public virtual Anu.Enumerations.WorkFlowActivityType? Type { get; set; }

		[Column("USERCANDELAY")]
		public virtual Anu.Enumerations.YesNo? UserCanDelay { get; set; }

		[Column("USERCHOOSETRANSITION")]
		public virtual Anu.Enumerations.YesNo? UserChooseTransition { get; set; }

    }
    [Table("WFACTIVITY")]
    public partial class WFActivity : WFActivityBase { }

    }


