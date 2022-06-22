

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration
{
    public abstract class GUserRoleFavMenuBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual long? OrderNo { get; set; }

		[ForeignKey("MENUSUBMENUID")]
		public virtual Anu.BaseInfo.SystemObject.MenuSubMenu? TheMenuSubMenu { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("GUSERROLEFAVMENU")]
    public partial class GUserRoleFavMenu : GUserRoleFavMenuBase { }

    }


