

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESUserAccessTypeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("GFESMENUID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESMenu? TheGFESMenu { get; set; }

        [InverseProperty("TheGFESUserAccessType")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESNJUnitRelatedUserAccess>? TheGFESNJUnitRelatedUserAccessList { get; set; }

        [InverseProperty("TheGFESUserAccessType")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESRoleTypeFavMenu>? TheGFESRoleTypeFavMenuList { get; set; }

        [InverseProperty("TheGFESUserAccessType")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessBaseRole>? TheGFESUserAccessBaseRoleList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GFESUSERACCESSTYPE")]
    public partial class GFESUserAccessType : GFESUserAccessTypeBase
    {
    }
    }