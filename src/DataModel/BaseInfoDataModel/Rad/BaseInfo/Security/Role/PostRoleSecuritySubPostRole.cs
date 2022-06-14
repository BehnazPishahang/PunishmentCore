

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class PostRoleSecuritySubPostRoleBase : BaseInfoEntity<string>
    {

		[ForeignKey("POSTROLEID")]
		public virtual Rad.BaseInfo.Security.Role.PostRole? ThePostRole { get; set; }

		[ForeignKey("POSTROLESECURITYID")]
		public virtual Rad.BaseInfo.Security.Role.PostRoleSecurity? ThePostRoleSecurity { get; set; }

    }
    [Table("POSTROLESECURITYSUBPOSTROLE")]
    public partial class PostRoleSecuritySubPostRole : PostRoleSecuritySubPostRoleBase { }

    }


