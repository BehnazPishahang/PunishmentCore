

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Explorer
{
    public abstract class ExplorerTransitionConditionBase : BaseInfoEntity<string>
    {

		[ForeignKey("EXPLORERNODETRANSITIONID")]
		public virtual Rad.Explorer.ExplorerNodeTransition? TheExplorerNodeTransition { get; set; }

		[ForeignKey("SYSTEMCONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? TheSystemCondition { get; set; }

    }
    [Table("EXPLORERTRANSITIONCONDITION")]
    public partial class ExplorerTransitionCondition : ExplorerTransitionConditionBase { }

    }


