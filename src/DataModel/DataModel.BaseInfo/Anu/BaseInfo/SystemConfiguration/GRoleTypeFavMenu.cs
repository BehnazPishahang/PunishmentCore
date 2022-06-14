

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemConfiguration
{
    public abstract class GRoleTypeFavMenuBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual long? OrderNo { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("MENUSUBMENUID")]
		public virtual Anu.BaseInfo.SystemObject.MenuSubMenu? TheMenuSubMenu { get; set; }

    }
    [Table("GROLETYPEFAVMENU")]
    public partial class GRoleTypeFavMenu : GRoleTypeFavMenuBase { }

    }


