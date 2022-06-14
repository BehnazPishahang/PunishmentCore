

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class SimpleBaseRoleBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("LATINNAME")]
		public virtual string? LatinName { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("SECURITYTYPE")]
		public virtual Rad.CMS.Enumerations.SecurityType? SecurityType { get; set; }

		[ForeignKey("SIMPLEBASEROLEID")]
		public virtual List<Rad.BaseInfo.Security.Role.BaseRolePermission>? TheBaseRolePermissionList { get; set; }

		[InverseProperty("TheSimpleBaseRole")]
		public virtual List<Rad.BaseInfo.Security.Role.FormBaseRole>? TheFormBaseRoleList { get; set; }

		[InverseProperty("TheSimpleBaseRole")]
		public virtual List<Rad.BaseInfo.Security.Role.SimpleBaseRoleFeature>? TheSimpleBaseRoleFeatureList { get; set; }

    }
    [Table("SIMPLEBASEROLE")]
    public partial class SimpleBaseRole : SimpleBaseRoleBase { }

    }


