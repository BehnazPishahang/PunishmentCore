

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Security.Role
{
    public abstract class BaseRoleBase : BaseInfoEntity<string>
    {

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("RESPITEDAY")]
		public virtual long? RespiteDay { get; set; }

		[Column("RESPITEMINUTE")]
		public virtual long? RespiteMinute { get; set; }

		[Column("SECURITYTYPE")]
		public virtual Anu.Enumerations.SecurityType? SecurityType { get; set; }

		[InverseProperty("TheBaseRole")]
		public virtual List<Anu.BaseInfo.Security.Role.FormBaseRole>? TheFormBaseRoleList { get; set; }

		[InverseProperty("TheActivity")]
		public virtual List<Anu.BaseInfo.Security.Role.PostRoleActivitySecurity>? ThePostRoleActivitySecurityList { get; set; }

    }
    [Table("BASEROLE")]
    public partial class BaseRole : BaseRoleBase { }

    }


