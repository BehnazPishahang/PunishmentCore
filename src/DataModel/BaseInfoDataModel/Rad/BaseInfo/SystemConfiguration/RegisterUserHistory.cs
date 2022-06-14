

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class RegisterUserHistoryBase : BaseInfoEntity<string>
    {

		[Column("FROMDATETIME")]
		public virtual string? FromDateTime { get; set; }

		[Column("SIGNTEXT")]
		public virtual string? SignText { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[Column("TODATETIME")]
		public virtual string? ToDateTime { get; set; }

    }
    [Table("REGISTERUSERHISTORY")]
    public partial class RegisterUserHistory : RegisterUserHistoryBase { }

    }


