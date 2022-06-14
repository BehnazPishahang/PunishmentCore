

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class BaseRolePermissionBase : BaseInfoEntity<string>
    {

		[Column("PERMISSIONTYPE")]
		public virtual Rad.CMS.Enumerations.PermissionType? PermissionType { get; set; }

		[ForeignKey("FORMCONTROLID")]
		public virtual Rad.BaseInfo.SystemObject.FormControl? TheFormControl { get; set; }

    }
    [Table("BASEROLEPERMISSION")]
    public partial class BaseRolePermission : BaseRolePermissionBase { }

    }


