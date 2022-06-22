

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public abstract class GFESUserAccessBase : BaseInfoEntity<string>
    {

		[Column("FROMDATETIME")]
		public virtual string? FromDateTime { get; set; }

		[Column("SIGNTEXT")]
		public virtual string? SignText { get; set; }

		[ForeignKey("GFESUSERID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUser? TheGFESUser { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

		[InverseProperty("TheGFESUserAccess")]
		public virtual List<Anu.BaseInfo.FrontEndSecurity.GFESUserRoleFavMenu>? TheGFESUserRoleFavMenuList { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[Column("TODATETIME")]
		public virtual string? ToDateTime { get; set; }

    }
    [Table("GFESUSERACCESS")]
    public partial class GFESUserAccess : GFESUserAccessBase { }

    }


