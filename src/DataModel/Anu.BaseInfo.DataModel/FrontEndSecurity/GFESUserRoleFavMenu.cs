

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESUserRoleFavMenuBase : BaseInfoEntity<string>
    {

        [Column("ORDERNO")]
        public virtual long? OrderNo { get; set; }

        [ForeignKey("GFESMENUSUBMENUID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESMenuSubMenu? TheGFESMenuSubMenu { get; set; }

        [ForeignKey("GFESUSERACCESSID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

    }

    [Table("GFESUSERROLEFAVMENU")]
    public partial class GFESUserRoleFavMenu : GFESUserRoleFavMenuBase
    {
    }
}