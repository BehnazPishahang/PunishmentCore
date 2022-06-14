

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class MenuSubMenuBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual decimal? OrderNo { get; set; }

		[ForeignKey("SUBMENUID")]
		public virtual Rad.BaseInfo.SystemObject.Menu? TheSubMenu { get; set; }

    }
    [Table("MENUSUBMENU")]
    public partial class MenuSubMenu : MenuSubMenuBase { }

    }


