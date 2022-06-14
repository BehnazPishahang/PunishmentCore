

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class PostRoleBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("ThePostRole")]
		public virtual List<Rad.BaseInfo.Security.Role.PostRoleSecurity>? ThePostRoleSecurityList { get; set; }

    }
    [Table("POSTROLE")]
    public partial class PostRole : PostRoleBase { }

    }


