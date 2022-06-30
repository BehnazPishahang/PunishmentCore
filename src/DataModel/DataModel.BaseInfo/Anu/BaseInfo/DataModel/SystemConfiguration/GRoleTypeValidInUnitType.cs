

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class GRoleTypeValidInUnitTypeBase : BaseInfoEntity<string>
    {

        [ForeignKey("CMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

        [ForeignKey("GUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.GUnitType? TheGUnitType { get; set; }

    }

    [Table("GROLETYPEVALIDINUNITTYPE")]
    public partial class GRoleTypeValidInUnitType : GRoleTypeValidInUnitTypeBase
    {
    }
}