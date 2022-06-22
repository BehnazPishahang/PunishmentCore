

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration
{
    public abstract class GRoleTypeValidInUnitTypeBase : BaseInfoEntity<string>
    {

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Anu.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

    }
    [Table("GROLETYPEVALIDINUNITTYPE")]
    public partial class GRoleTypeValidInUnitType : GRoleTypeValidInUnitTypeBase { }

    }


