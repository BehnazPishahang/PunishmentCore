

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Position
{
    public abstract class UserDefinePosBasePosBase : BaseInfoEntity<string>
    {

		[ForeignKey("BASEPOSITIONID")]
		public virtual Rad.BaseInfo.Security.Position.BasePosition? TheBasePosition { get; set; }

		[ForeignKey("USERDEFINEPOSITIONID")]
		public virtual Rad.BaseInfo.Security.Position.UserDefinePosition? TheUserDefinePosition { get; set; }

    }
    [Table("USERDEFINEPOSBASEPOS")]
    public partial class UserDefinePosBasePos : UserDefinePosBasePosBase { }

    }


