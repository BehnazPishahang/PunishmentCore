

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public abstract class GFESUserAccessBaseRoleBase : BaseInfoEntity<string>
    {

		[ForeignKey("BASEROLEID")]
		public virtual Anu.BaseInfo.Security.Role.BaseRole? TheBaseRole { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

    }
    [Table("GFESUSERACCESSBASEROLE")]
    public partial class GFESUserAccessBaseRole : GFESUserAccessBaseRoleBase { }

    }


