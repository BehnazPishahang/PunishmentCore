

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class BaseRoleBase : BaseInfoEntity<string>
    {

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("RESPITEDAY")]
		public virtual decimal? RespiteDay { get; set; }

		[Column("RESPITEMINUTE")]
		public virtual decimal? RespiteMinute { get; set; }

		[Column("SECURITYTYPE")]
		public virtual Rad.CMS.Enumerations.SecurityType? SecurityType { get; set; }

		[ForeignKey("BASEROLEID")]
		public virtual List<Rad.BaseInfo.Security.Role.BaseRolePermission>? TheBaseRolePermissionList { get; set; }

		[ForeignKey("BASEROLEID")]
		public virtual List<Rad.BaseInfo.Security.Role.BaseRoleVariable>? TheBaseRoleVariableList { get; set; }

		[InverseProperty("TheBaseRole")]
		public virtual List<Rad.BaseInfo.Security.Role.FormBaseRole>? TheFormBaseRoleList { get; set; }

    }
    [Table("BASEROLE")]
    public partial class BaseRole : BaseRoleBase { }

    }


