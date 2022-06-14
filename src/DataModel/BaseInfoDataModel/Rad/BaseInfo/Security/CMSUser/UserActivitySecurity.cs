

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.CMSUser
{
    public abstract class UserActivitySecurityBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("SECURITYCOUNT")]
		public virtual decimal? SecurityCount { get; set; }

		[ForeignKey("ACTIVITYID")]
		public virtual Rad.BaseInfo.Security.Role.BaseRole? TheActivity { get; set; }

		[ForeignKey("POSTCONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? ThePostCondition { get; set; }

		[ForeignKey("PRECONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? ThePreCondition { get; set; }

    }
    [Table("USERACTIVITYSECURITY")]
    public partial class UserActivitySecurity : UserActivitySecurityBase { }

    }


