

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemConfiguration
{
    public abstract class RegisterUserHistoryBase : BaseInfoEntity<string>
    {

		[Column("FROMDATETIME")]
		public virtual string? FromDateTime { get; set; }

		[Column("SIGNTEXT")]
		public virtual string? SignText { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[InverseProperty("TheRegisterUserHistory")]
		public virtual List<Anu.BaseInfo.SystemConfiguration.GUserRoleFavMenu>? TheGUserRoleFavMenuList { get; set; }

		[Column("TODATETIME")]
		public virtual string? ToDateTime { get; set; }

    }
    [Table("REGISTERUSERHISTORY")]
    public partial class RegisterUserHistory : RegisterUserHistoryBase { }

    }


