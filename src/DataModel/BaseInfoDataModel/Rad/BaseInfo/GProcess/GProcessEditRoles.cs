

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessEditRolesBase : BaseInfoEntity<string>
    {

		[Column("CANCELFINISHSTATEPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? CancelFinishStatePermision { get; set; }

		[Column("DELETEREQUESTPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? DeleteRequestPermission { get; set; }

		[Column("FINISHREQUESTPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? FinishRequestPermision { get; set; }

		[Column("ISADMIN")]
		public virtual bool? IsAdmin { get; set; }

		[Column("NEWREQUESTPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? NewRequestPermission { get; set; }

		[Column("REFERCHANGEPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ReferChangePermision { get; set; }

		[Column("RESUMEREQUESTPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ResumeRequestPermision { get; set; }

		[Column("STOPREQUESTPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? StopRequestPermision { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("GPROCESSID")]
		public virtual Rad.BaseInfo.GProcess.GProcess? TheGProcess { get; set; }

    }
    [Table("GPROCESSEDITROLES")]
    public partial class GProcessEditRoles : GProcessEditRolesBase { }

    }


