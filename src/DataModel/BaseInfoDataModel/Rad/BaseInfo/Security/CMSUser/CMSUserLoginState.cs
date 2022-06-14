

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.CMSUser
{
    public abstract class CMSUserLoginStateBase : BaseInfoEntity<string>
    {

		[Column("ISFORCELOGOFFREQUIRED")]
		public virtual Rad.CMS.Enumerations.YesNo? IsForceLogoffRequired { get; set; }

		[Column("LASTLOGINDATETIME")]
		public virtual string? LastLoginDateTime { get; set; }

		[Column("SESSIONID")]
		public virtual string? SessionId { get; set; }

		[Column("SYSTEMNAME")]
		public virtual string? SystemName { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("CMSUSERLOGINSTATE")]
    public partial class CMSUserLoginState : CMSUserLoginStateBase { }

    }


