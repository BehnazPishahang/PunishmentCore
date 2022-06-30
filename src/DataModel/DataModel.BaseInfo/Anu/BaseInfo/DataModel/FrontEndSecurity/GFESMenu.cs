

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESMenuBase : BaseInfoEntity<string>
    {

        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("DIRECTCOMMAND")]
        public virtual string? DirectCommand { get; set; }

        [Column("MENUITEMSTATE")]
        public virtual Anu.BaseInfo.Enumerations.MenuItemState? MenuItemState { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [InverseProperty("TheSubMenu")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESMenuSubMenu>? TheMainMenusList { get; set; }

        [InverseProperty("TheMainMenu")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESMenuSubMenu>? TheSubMensList { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

    }

    [Table("GFESMENU")]
    public partial class GFESMenu : GFESMenuBase
    {
    }
}