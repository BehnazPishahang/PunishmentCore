

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESUserAccessBase : BaseInfoEntity<string>
    {

        [Column("FROMDATETIME")]
        public virtual string? FromDateTime { get; set; }

        [Column("SIGNTEXT")]
        public virtual string? SignText { get; set; }

        [ForeignKey("GFESUSERID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser? TheGFESUser { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

        [InverseProperty("TheGFESUserAccess")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserRoleFavMenu>? TheGFESUserRoleFavMenuList { get; set; }

        [ForeignKey("NAJAUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

        [Column("TODATETIME")]
        public virtual string? ToDateTime { get; set; }

    }

    [Table("GFESUSERACCESS")]
    public partial class GFESUserAccess : GFESUserAccessBase
    {
    }
}