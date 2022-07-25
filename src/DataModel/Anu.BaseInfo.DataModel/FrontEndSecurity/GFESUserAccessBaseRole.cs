

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESUserAccessBaseRoleBase : BaseInfoEntity<string>
    {

        [ForeignKey("BASEROLEID")]
        public virtual Anu.BaseInfo.DataModel.Security.Role.BaseRole? TheBaseRole { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

    }

    [Table("GFESUSERACCESSBASEROLE")]
    public partial class GFESUserAccessBaseRole : GFESUserAccessBaseRoleBase
    {
    }
}