

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.CMSUser
{
    public abstract class UserSecurityBase : BaseInfoEntity<string>
    {

		[Column("ENDDATETIME")]
		public virtual string? EndDateTime { get; set; }

		[Column("NO")]
		public virtual decimal? No { get; set; }

		[Column("STARTDATETIME")]
		public virtual string? StartDateTime { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("USERSECURITYID")]
		public virtual List<Rad.BaseInfo.Security.CMSUser.UserActivitySecurity>? TheUserActivitySecurityList { get; set; }

		[ForeignKey("USERSECURITYID")]
		public virtual List<Rad.BaseInfo.Security.CMSUser.UserFolderSecurity>? TheUserFolderSecurityList { get; set; }

		[ForeignKey("USERSECURITYID")]
		public virtual List<Rad.BaseInfo.Security.CMSUser.UserPostRoleSecurity>? TheUserPostRoleSecurityList { get; set; }

		[ForeignKey("USERSECURITYID")]
		public virtual List<Rad.BaseInfo.Security.CMSUser.UserViewSecurity>? TheUserViewSecurityList { get; set; }

    }
    [Table("USERSECURITY")]
    public partial class UserSecurity : UserSecurityBase { }

    }


