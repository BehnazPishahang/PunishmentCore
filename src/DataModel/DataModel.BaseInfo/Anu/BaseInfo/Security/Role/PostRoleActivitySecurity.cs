

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Security.Role
{
    public abstract class PostRoleActivitySecurityBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[ForeignKey("ACTIVITYID")]
		public virtual Anu.BaseInfo.Security.Role.BaseRole? TheActivity { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

    }
    [Table("POSTROLEACTIVITYSECURITY")]
    public partial class PostRoleActivitySecurity : PostRoleActivitySecurityBase { }

    }


