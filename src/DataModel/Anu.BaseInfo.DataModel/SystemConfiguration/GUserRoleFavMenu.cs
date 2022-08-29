using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class GUserRoleFavMenuBase : BaseInfoEntity<string>
    {

        [Column("ORDERNO")]
        public virtual long? OrderNo { get; set; }

        [ForeignKey("MENUSUBMENUID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.MenuSubMenu? TheMenuSubMenu { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        }

    [Table("GUSERROLEFAVMENU")]
    public partial class GUserRoleFavMenu : GUserRoleFavMenuBase
    {
    }
    }