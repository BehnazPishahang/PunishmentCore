using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class RegisterUserHistoryBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FROMDATETIME")]
        public virtual string? FromDateTime { get; set; }

        [Unicode(false)]
        [Column("SIGNTEXT")]
        public virtual string? SignText { get; set; }

        [ForeignKey("CMSORGANIZATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

        [ForeignKey("CMSUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

        [ForeignKey("CMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

        [InverseProperty("TheRegisterUserHistory")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.GUserRoleFavMenu>? TheGUserRoleFavMenuList { get; set; }

        [Unicode(false)]
        [Column("TODATETIME")]
        public virtual string? ToDateTime { get; set; }

        }

    [Table("REGISTERUSERHISTORY")]
    public partial class RegisterUserHistory : RegisterUserHistoryBase
    {
    }
    }