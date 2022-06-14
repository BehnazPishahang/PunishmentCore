

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemConfiguration
{
    public abstract class CMSUserRoleTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ISSYSTEMMANAGER")]
		public virtual Anu.Enumerations.YesNo? IsSystemManager { get; set; }

		[Column("MULTISESSIONPOLICY")]
		public virtual Anu.Enumerations.MultiSessionPolicy? MultiSessionPolicy { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheCMSUserRoleType")]
		public virtual List<Anu.BaseInfo.SystemConfiguration.GRoleTypeFavMenu>? TheGRoleTypeFavMenuList { get; set; }

		[InverseProperty("TheCMSUserRoleType")]
		public virtual List<Anu.BaseInfo.SystemConfiguration.GRoleTypeValidInUnitType>? TheGRoleTypeValidInUnitTypeList { get; set; }

		[ForeignKey("MENUID")]
		public virtual Anu.BaseInfo.SystemObject.Menu? TheMenu { get; set; }

		[InverseProperty("TheCMSUserRoleType")]
		public virtual List<Anu.BaseInfo.Security.Role.PostRoleActivitySecurity>? ThePostRoleActivitySecurityList { get; set; }

		[Column("TOKENREQUIRED")]
		public virtual Anu.Enumerations.YesNo? TokenRequired { get; set; }

    }
    [Table("CMSUSERROLETYPE")]
    public partial class CMSUserRoleType : CMSUserRoleTypeBase { }

    }


