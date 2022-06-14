

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class CMSUserRoleTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ISMECHANIZESEC")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMechanizeSec { get; set; }

		[Column("ISSYSTEMMANAGER")]
		public virtual Rad.CMS.Enumerations.YesNo? IsSystemManager { get; set; }

		[Column("MULTISESSIONPOLICY")]
		public virtual Rad.CMS.Enumerations.MultiSessionPolicy? MultiSessionPolicy { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("RELATEDSUBSYSTEM")]
		public virtual Rad.CMS.Enumerations.Subsystems? RelatedSubsystem { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheCMSUserRoleType")]
		public virtual List<Rad.BaseInfo.Security.Role.CMSUserRoleTypeSimpleRole>? TheCMSUserRoleTypeSimpleRoleList { get; set; }

		[InverseProperty("TheCMSUserRoleType")]
		public virtual List<Rad.BaseInfo.SystemConfiguration.GRoleTypeValidInUnitType>? TheGRoleTypeValidInUnitTypeList { get; set; }

		[ForeignKey("MENUID")]
		public virtual Rad.BaseInfo.SystemObject.Menu? TheMenu { get; set; }

		[ForeignKey("POSTROLEID")]
		public virtual Rad.BaseInfo.Security.Role.PostRole? ThePostRole { get; set; }

		[Column("TOKENREQUIRED")]
		public virtual Rad.CMS.Enumerations.YesNo? TokenRequired { get; set; }

    }
    [Table("CMSUSERROLETYPE")]
    public partial class CMSUserRoleType : CMSUserRoleTypeBase { }

    }


