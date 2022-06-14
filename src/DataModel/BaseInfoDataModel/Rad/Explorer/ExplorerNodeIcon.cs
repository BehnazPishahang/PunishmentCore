

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Explorer
{
    public abstract class ExplorerNodeIconBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("FILEBODY")]
		public virtual byte[]? FileBody { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("EXPLORERNODEICON")]
    public partial class ExplorerNodeIcon : ExplorerNodeIconBase { }

    }


