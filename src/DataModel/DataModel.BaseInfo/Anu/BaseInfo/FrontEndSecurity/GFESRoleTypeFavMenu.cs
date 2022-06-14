

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.FrontEndSecurity
{
    public abstract class GFESRoleTypeFavMenuBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual long? OrderNo { get; set; }

		[ForeignKey("GFESMENUSUBMENUID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESMenuSubMenu? TheGFESMenuSubMenu { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

    }
    [Table("GFESROLETYPEFAVMENU")]
    public partial class GFESRoleTypeFavMenu : GFESRoleTypeFavMenuBase { }

    }


