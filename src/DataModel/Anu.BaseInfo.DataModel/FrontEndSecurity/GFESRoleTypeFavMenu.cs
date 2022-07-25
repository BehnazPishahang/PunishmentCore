

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESRoleTypeFavMenuBase : BaseInfoEntity<string>
    {

        [Column("ORDERNO")]
        public virtual long? OrderNo { get; set; }

        [ForeignKey("GFESMENUSUBMENUID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESMenuSubMenu? TheGFESMenuSubMenu { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

    }

    [Table("GFESROLETYPEFAVMENU")]
    public partial class GFESRoleTypeFavMenu : GFESRoleTypeFavMenuBase
    {
    }
}