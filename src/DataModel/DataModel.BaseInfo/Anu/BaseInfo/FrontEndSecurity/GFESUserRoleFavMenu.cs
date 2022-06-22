

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public abstract class GFESUserRoleFavMenuBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual long? OrderNo { get; set; }

		[ForeignKey("GFESMENUSUBMENUID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESMenuSubMenu? TheGFESMenuSubMenu { get; set; }

		[ForeignKey("GFESUSERACCESSID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

    }
    [Table("GFESUSERROLEFAVMENU")]
    public partial class GFESUserRoleFavMenu : GFESUserRoleFavMenuBase { }

    }


