

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Explorer
{
    public abstract class ExplorerNodeConditionBase : BaseInfoEntity<string>
    {

		[ForeignKey("EXPLORERNODEID")]
		public virtual Rad.Explorer.ExplorerNode? TheExplorerNode { get; set; }

		[ForeignKey("SYSTEMCONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? TheSystemCondition { get; set; }

    }
    [Table("EXPLORERNODECONDITION")]
    public partial class ExplorerNodeCondition : ExplorerNodeConditionBase { }

    }


