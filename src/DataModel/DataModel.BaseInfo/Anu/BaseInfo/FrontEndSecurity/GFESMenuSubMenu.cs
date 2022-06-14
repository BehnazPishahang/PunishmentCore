

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.FrontEndSecurity
{
    public abstract class GFESMenuSubMenuBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual long? OrderNo { get; set; }

		[InverseProperty("TheGFESMenuSubMenu")]
		public virtual List<Anu.BaseInfo.FrontEndSecurity.GFESRoleTypeFavMenu>? TheGFESRoleTypeFavMenuList { get; set; }

		[InverseProperty("TheGFESMenuSubMenu")]
		public virtual List<Anu.BaseInfo.FrontEndSecurity.GFESUserRoleFavMenu>? TheGFESUserRoleFavMenuList { get; set; }

		[ForeignKey("MAINMENUID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESMenu? TheMainMenu { get; set; }

		[ForeignKey("SUBMENUID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESMenu? TheSubMenu { get; set; }

    }
    [Table("GFESMENUSUBMENU")]
    public partial class GFESMenuSubMenu : GFESMenuSubMenuBase { }

    }


