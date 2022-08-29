using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESMenuBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("DIRECTCOMMAND")]
        public virtual string? DirectCommand { get; set; }

        [Column("MENUITEMSTATE")]
        public virtual Anu.BaseInfo.Enumerations.MenuItemState? MenuItemState { get; set; }

        [Unicode(false)]
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