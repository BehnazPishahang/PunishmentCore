

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class MenuBase : BaseInfoEntity<string>
    {

        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("DIRECTCOMMAND")]
        public virtual string? DirectCommand { get; set; }

        [Column("MENUITEMSTATE")]
        public virtual Anu.BaseInfo.Enumerations.MenuItemState? MenuItemState { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [ForeignKey("GICONID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.GIcon? TheGIcon { get; set; }

        [ForeignKey("MENUID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.MenuSubMenu>? TheMenuSubMenuList { get; set; }

        [ForeignKey("SHORTCUTKEYSID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ShortCutKeys? TheShortCutKeys { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

    }

    [Table("MENU")]
    public partial class Menu : MenuBase
    {
    }
}