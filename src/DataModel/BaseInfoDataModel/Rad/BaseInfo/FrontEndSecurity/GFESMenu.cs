

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.FrontEndSecurity
{
    public abstract class GFESMenuBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DIRECTCOMMAND")]
		public virtual string? DirectCommand { get; set; }

		[Column("MENUITEMSTATE")]
		public virtual Rad.CMS.Enumerations.MenuItemState? MenuItemState { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[InverseProperty("TheSubMenu")]
		public virtual List<Rad.BaseInfo.FrontEndSecurity.GFESMenuSubMenu>? TheMainMenusList { get; set; }

		[InverseProperty("TheMainMenu")]
		public virtual List<Rad.BaseInfo.FrontEndSecurity.GFESMenuSubMenu>? TheSubMensList { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("GFESMENU")]
    public partial class GFESMenu : GFESMenuBase { }

    }


