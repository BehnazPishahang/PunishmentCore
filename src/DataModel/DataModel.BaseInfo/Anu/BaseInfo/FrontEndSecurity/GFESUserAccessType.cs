

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public abstract class GFESUserAccessTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("GFESMENUID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESMenu? TheGFESMenu { get; set; }

		[InverseProperty("TheGFESUserAccessType")]
		public virtual List<Anu.BaseInfo.FrontEndSecurity.GFESNJUnitRelatedUserAccess>? TheGFESNJUnitRelatedUserAccessList { get; set; }

		[InverseProperty("TheGFESUserAccessType")]
		public virtual List<Anu.BaseInfo.FrontEndSecurity.GFESRoleTypeFavMenu>? TheGFESRoleTypeFavMenuList { get; set; }

		[InverseProperty("TheGFESUserAccessType")]
		public virtual List<Anu.BaseInfo.FrontEndSecurity.GFESUserAccessBaseRole>? TheGFESUserAccessBaseRoleList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GFESUSERACCESSTYPE")]
    public partial class GFESUserAccessType : GFESUserAccessTypeBase { }

    }


