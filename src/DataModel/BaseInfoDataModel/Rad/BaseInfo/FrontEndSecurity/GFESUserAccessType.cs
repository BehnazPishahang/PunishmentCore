

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.FrontEndSecurity
{
    public abstract class GFESUserAccessTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("GFESMENUID")]
		public virtual Rad.BaseInfo.FrontEndSecurity.GFESMenu? TheGFESMenu { get; set; }

		[InverseProperty("TheGFESUserAccessType")]
		public virtual List<Rad.BaseInfo.FrontEndSecurity.GFESUserAccessBaseRole>? TheGFESUserAccessBaseRoleList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GFESUSERACCESSTYPE")]
    public partial class GFESUserAccessType : GFESUserAccessTypeBase { }

    }


