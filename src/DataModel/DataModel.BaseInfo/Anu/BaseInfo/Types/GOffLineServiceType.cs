

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.Types
{
    public abstract class GOffLineServiceTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GOFFLINESERVICETYPE")]
    public partial class GOffLineServiceType : GOffLineServiceTypeBase { }

    }


