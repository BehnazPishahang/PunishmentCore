

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.WorkFlow.WFDefine
{
    public abstract class WFActivityEventCreateBase : BaseInfoEntity<string>
    {

		[Column("ACTIONTIME")]
		public virtual Anu.Enumerations.WorkFlowActionTime? ActionTime { get; set; }

		[ForeignKey("WFACTIVITYID")]
		public virtual Anu.WorkFlow.WFDefine.WFActivity? TheWFActivity { get; set; }

		[ForeignKey("WFEVENTID")]
		public virtual Anu.WorkFlow.WFDefine.WFEvent? TheWFEvent { get; set; }

    }
    [Table("WFACTIVITYEVENTCREATE")]
    public partial class WFActivityEventCreate : WFActivityEventCreateBase { }

    }


