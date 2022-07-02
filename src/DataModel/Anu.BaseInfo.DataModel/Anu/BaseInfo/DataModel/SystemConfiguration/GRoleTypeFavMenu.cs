

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class GRoleTypeFavMenuBase : BaseInfoEntity<string>
    {

        [Column("ORDERNO")]
        public virtual long? OrderNo { get; set; }

        [ForeignKey("CMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

        [ForeignKey("MENUSUBMENUID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.MenuSubMenu? TheMenuSubMenu { get; set; }

    }

    [Table("GROLETYPEFAVMENU")]
    public partial class GRoleTypeFavMenu : GRoleTypeFavMenuBase
    {
    }
}