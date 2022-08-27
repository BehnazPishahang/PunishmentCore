using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class CMSUserRoleTypeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("ISSYSTEMMANAGER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsSystemManager { get; set; }

        [Column("MULTISESSIONPOLICY")]
        public virtual Anu.BaseInfo.Enumerations.MultiSessionPolicy? MultiSessionPolicy { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheCMSUserRoleType")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.GRoleTypeFavMenu>? TheGRoleTypeFavMenuList { get; set; }

        [InverseProperty("TheCMSUserRoleType")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.GRoleTypeValidInUnitType>? TheGRoleTypeValidInUnitTypeList { get; set; }

        [ForeignKey("MENUID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.Menu? TheMenu { get; set; }

        [InverseProperty("TheCMSUserRoleType")]
        public virtual List<Anu.BaseInfo.DataModel.Security.Role.PostRoleActivitySecurity>? ThePostRoleActivitySecurityList { get; set; }

        [Column("TOKENREQUIRED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? TokenRequired { get; set; }

        }

    [Table("CMSUSERROLETYPE")]
    public partial class CMSUserRoleType : CMSUserRoleTypeBase
    {
    }
    }