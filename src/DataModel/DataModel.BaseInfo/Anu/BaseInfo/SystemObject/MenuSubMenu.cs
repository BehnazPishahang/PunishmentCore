

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemObject
{
    public abstract class MenuSubMenuBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual long? OrderNo { get; set; }

		[InverseProperty("TheMenuSubMenu")]
		public virtual List<Anu.BaseInfo.SystemConfiguration.GRoleTypeFavMenu>? TheGRoleTypeFavMenuList { get; set; }

		[InverseProperty("TheMenuSubMenu")]
		public virtual List<Anu.BaseInfo.SystemConfiguration.GUserRoleFavMenu>? TheGUserRoleFavMenuList { get; set; }

		[ForeignKey("SUBMENUID")]
		public virtual Anu.BaseInfo.SystemObject.Menu? TheSubMenu { get; set; }

    }
    [Table("MENUSUBMENU")]
    public partial class MenuSubMenu : MenuSubMenuBase { }

    }


