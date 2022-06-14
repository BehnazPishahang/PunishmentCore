

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.FrontEndSecurity
{
    public abstract class GFESMenuSubMenuBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual decimal? OrderNo { get; set; }

		[ForeignKey("MAINMENUID")]
		public virtual Rad.BaseInfo.FrontEndSecurity.GFESMenu? TheMainMenu { get; set; }

		[ForeignKey("SUBMENUID")]
		public virtual Rad.BaseInfo.FrontEndSecurity.GFESMenu? TheSubMenu { get; set; }

    }
    [Table("GFESMENUSUBMENU")]
    public partial class GFESMenuSubMenu : GFESMenuSubMenuBase { }

    }


