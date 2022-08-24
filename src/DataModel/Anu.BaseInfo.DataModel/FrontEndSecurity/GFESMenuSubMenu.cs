using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESMenuSubMenuBase : BaseInfoEntity<string>
    {

        [Column("ORDERNO")]
        public virtual long? OrderNo { get; set; }

        [InverseProperty("TheGFESMenuSubMenu")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESRoleTypeFavMenu>? TheGFESRoleTypeFavMenuList { get; set; }

        [InverseProperty("TheGFESMenuSubMenu")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserRoleFavMenu>? TheGFESUserRoleFavMenuList { get; set; }

        [ForeignKey("MAINMENUID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESMenu? TheMainMenu { get; set; }

        [ForeignKey("SUBMENUID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESMenu? TheSubMenu { get; set; }

        }

    [Table("GFESMENUSUBMENU")]
    public partial class GFESMenuSubMenu : GFESMenuSubMenuBase
    {
    }
    }