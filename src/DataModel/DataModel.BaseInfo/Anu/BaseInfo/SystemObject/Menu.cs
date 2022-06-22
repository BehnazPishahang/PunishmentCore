

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemObject
{
    public abstract class MenuBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DIRECTCOMMAND")]
		public virtual string? DirectCommand { get; set; }

		[Column("MENUITEMSTATE")]
		public virtual Anu.Enumerations.MenuItemState? MenuItemState { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[ForeignKey("GICONID")]
		public virtual Anu.BaseInfo.SystemObject.GIcon? TheGIcon { get; set; }

		[ForeignKey("MENUID")]
		public virtual List<Anu.BaseInfo.SystemObject.MenuSubMenu>? TheMenuSubMenuList { get; set; }

		[ForeignKey("SHORTCUTKEYSID")]
		public virtual Anu.BaseInfo.SystemObject.ShortCutKeys? TheShortCutKeys { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("MENU")]
    public partial class Menu : MenuBase { }

    }


