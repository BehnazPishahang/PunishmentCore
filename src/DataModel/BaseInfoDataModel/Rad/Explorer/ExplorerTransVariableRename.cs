

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Explorer
{
    public abstract class ExplorerTransVariableRenameBase : BaseInfoEntity<string>
    {

		[ForeignKey("DESTINATIONVARIABLEID")]
		public virtual Rad.Explorer.ExplorerVariable? TheDestinationVariable { get; set; }

		[ForeignKey("SOURCEVARIABLEID")]
		public virtual Rad.Explorer.ExplorerVariable? TheSourceVariable { get; set; }

    }
    [Table("EXPLORERTRANSVARIABLERENAME")]
    public partial class ExplorerTransVariableRename : ExplorerTransVariableRenameBase { }

    }


