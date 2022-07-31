

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBActivityBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("ISNEEDIDENTIFIEDUSER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsNeedIdentifiedUser { get; set; }

        [Column("ISSTARTER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsStarter { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("CMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

        [ForeignKey("GUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.GUnitType? TheGUnitType { get; set; }

    }

    [Table("JBACTIVITY")]
    public partial class JBActivity : JBActivityBase
    {
    }
    }