

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class PostRoleSecurityBase : BaseInfoEntity<string>
    {

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("NO")]
		public virtual decimal? No { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("POSTROLEID")]
		public virtual Rad.BaseInfo.Security.Role.PostRole? ThePostRole { get; set; }

		[ForeignKey("POSTROLESECURITYID")]
		public virtual List<Rad.BaseInfo.Security.Role.PostRoleActivitySecurity>? ThePostRoleActivitySecurityList { get; set; }

		[InverseProperty("ThePostRoleSecurity")]
		public virtual List<Rad.BaseInfo.Security.Role.PostRoleSecuritySubPostRole>? ThePostRoleSecuritySubPostRoleList { get; set; }

		[ForeignKey("POSTROLESECURITYID")]
		public virtual List<Rad.BaseInfo.Security.Role.PostRoleViewSecurity>? ThePostRoleViewSecurityList { get; set; }

    }
    [Table("POSTROLESECURITY")]
    public partial class PostRoleSecurity : PostRoleSecurityBase { }

    }


