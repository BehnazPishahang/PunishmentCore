

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class SimpleBaseRoleFeatureBase : BaseInfoEntity<string>
    {

		[Column("CREATEACCESS")]
		public virtual Rad.CMS.Enumerations.YesNo? CreateAccess { get; set; }

		[Column("DELETEACCESS")]
		public virtual Rad.CMS.Enumerations.YesNo? DeleteAccess { get; set; }

		[Column("EDITACCESS")]
		public virtual Rad.CMS.Enumerations.YesNo? EditAccess { get; set; }

		[ForeignKey("SECURITYFEATUREID")]
		public virtual Rad.BaseInfo.Security.Role.SecurityFeature? TheSecurityFeature { get; set; }

		[ForeignKey("SIMPLEBASEROLEID")]
		public virtual Rad.BaseInfo.Security.Role.SimpleBaseRole? TheSimpleBaseRole { get; set; }

		[Column("VIEWACCESS")]
		public virtual Rad.CMS.Enumerations.YesNo? ViewAccess { get; set; }

    }
    [Table("SIMPLEBASEROLEFEATURE")]
    public partial class SimpleBaseRoleFeature : SimpleBaseRoleFeatureBase { }

    }


