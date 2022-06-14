

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class CMSUserRoleTypeSimpleRoleBase : BaseInfoEntity<string>
    {

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("POSTCONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? ThePostCondition { get; set; }

		[ForeignKey("PRECONDITIONID")]
		public virtual Rad.BaseInfo.SystemObject.SystemCondition? ThePreCondition { get; set; }

		[ForeignKey("SIMPLEBASEROLEID")]
		public virtual Rad.BaseInfo.Security.Role.SimpleBaseRole? TheSimpleBaseRole { get; set; }

    }
    [Table("CMSUSERROLETYPESIMPLEROLE")]
    public partial class CMSUserRoleTypeSimpleRole : CMSUserRoleTypeSimpleRoleBase { }

    }


