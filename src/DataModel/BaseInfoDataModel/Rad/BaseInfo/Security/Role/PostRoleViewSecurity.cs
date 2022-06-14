

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class PostRoleViewSecurityBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[ForeignKey("POSTCONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? ThePostCondition { get; set; }

		[ForeignKey("PRECONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? ThePreCondition { get; set; }

		[ForeignKey("USERDEFINEPOSITIONID")]
		public virtual Rad.BaseInfo.Security.Position.UserDefinePosition? TheUserDefinePosition { get; set; }

    }
    [Table("POSTROLEVIEWSECURITY")]
    public partial class PostRoleViewSecurity : PostRoleViewSecurityBase { }

    }


