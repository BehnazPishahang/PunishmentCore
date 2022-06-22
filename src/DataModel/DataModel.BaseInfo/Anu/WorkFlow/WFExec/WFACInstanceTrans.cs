

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.WorkFlow.WFExec
{
    public abstract class WFACInstanceTransBase : BaseInfoEntity<string>
    {

		[ForeignKey("WFACINSTANCEID")]
		public virtual Anu.WorkFlow.WFExec.WFACInstance? TheWFACInstance { get; set; }

		[ForeignKey("WFACTIVITYTRANSITIONID")]
		public virtual Anu.WorkFlow.WFDefine.WFActivityTransition? TheWFActivityTransition { get; set; }

    }
    [Table("WFACINSTANCETRANS")]
    public partial class WFACInstanceTrans : WFACInstanceTransBase { }

    }


