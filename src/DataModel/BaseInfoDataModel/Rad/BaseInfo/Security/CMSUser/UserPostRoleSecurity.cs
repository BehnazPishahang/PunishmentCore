

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.CMSUser
{
    public abstract class UserPostRoleSecurityBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("SECURITYCOUNT")]
		public virtual decimal? SecurityCount { get; set; }

		[ForeignKey("POSTROLEID")]
		public virtual Rad.BaseInfo.Security.Role.PostRole? ThePostRole { get; set; }

    }
    [Table("USERPOSTROLESECURITY")]
    public partial class UserPostRoleSecurity : UserPostRoleSecurityBase { }

    }


