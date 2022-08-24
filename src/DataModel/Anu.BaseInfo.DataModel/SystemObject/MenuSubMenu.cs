using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class MenuSubMenuBase : BaseInfoEntity<string>
    {

        [Column("ORDERNO")]
        public virtual long? OrderNo { get; set; }

        [InverseProperty("TheMenuSubMenu")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.GRoleTypeFavMenu>? TheGRoleTypeFavMenuList { get; set; }

        [InverseProperty("TheMenuSubMenu")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.GUserRoleFavMenu>? TheGUserRoleFavMenuList { get; set; }

        [ForeignKey("SUBMENUID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.Menu? TheSubMenu { get; set; }

        }

    [Table("MENUSUBMENU")]
    public partial class MenuSubMenu : MenuSubMenuBase
    {
    }
    }