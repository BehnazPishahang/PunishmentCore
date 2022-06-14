

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.CMSUser
{
    public abstract class UserViewSecurityBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("SECURITYCOUNT")]
		public virtual decimal? SecurityCount { get; set; }

		[ForeignKey("POSTCONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? ThePostCondition { get; set; }

		[ForeignKey("PRECONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? ThePreCondition { get; set; }

		[ForeignKey("USERDEFINEPOSITIONID")]
		public virtual Rad.BaseInfo.Security.Position.UserDefinePosition? TheUserDefinePosition { get; set; }

    }
    [Table("USERVIEWSECURITY")]
    public partial class UserViewSecurity : UserViewSecurityBase { }

    }


