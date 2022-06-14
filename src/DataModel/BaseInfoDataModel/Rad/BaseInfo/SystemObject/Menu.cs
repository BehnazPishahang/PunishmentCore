

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class MenuBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DIRECTCOMMAND")]
		public virtual string? DirectCommand { get; set; }

		[Column("MENUITEMSTATE")]
		public virtual Rad.CMS.Enumerations.MenuItemState? MenuItemState { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[ForeignKey("MENUID")]
		public virtual List<Rad.BaseInfo.SystemObject.MenuSubMenu>? TheMenuSubMenuList { get; set; }

		[ForeignKey("SHORTCUTKEYSID")]
		public virtual Rad.BaseInfo.SystemObject.ShortCutKeys? TheShortCutKeys { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("MENU")]
    public partial class Menu : MenuBase { }

    }


