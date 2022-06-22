

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBActivityBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ISNEEDIDENTIFIEDUSER")]
		public virtual Anu.Enumerations.YesNo? IsNeedIdentifiedUser { get; set; }

		[Column("ISSTARTER")]
		public virtual Anu.Enumerations.YesNo? IsStarter { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Anu.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

    }
    [Table("JBACTIVITY")]
    public partial class JBActivity : JBActivityBase { }

    }


