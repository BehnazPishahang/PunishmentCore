

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.WorkFlow.WFDefine
{
    public abstract class WFActivityTransitionBase : BaseInfoEntity<string>
    {

		[ForeignKey("CURRENTACTIVITYID")]
		public virtual Anu.WorkFlow.WFDefine.WFActivity? TheCurrentActivity { get; set; }

		[ForeignKey("NEXTACTIVITYID")]
		public virtual Anu.WorkFlow.WFDefine.WFActivity? TheNextActivity { get; set; }

    }
    [Table("WFACTIVITYTRANSITION")]
    public partial class WFActivityTransition : WFActivityTransitionBase { }

    }


