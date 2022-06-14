

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Position
{
    public abstract class UserDefinePositionBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[InverseProperty("TheUserDefinePosition")]
		public virtual List<Rad.BaseInfo.Security.Position.UserDefinePosBasePos>? TheUserDefinePosBasePosList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("USERDEFINEPOSITION")]
    public partial class UserDefinePosition : UserDefinePositionBase { }

    }


