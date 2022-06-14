

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Dashboard
{
    public abstract class PDashboardUserBase : PunishmentOrgEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("COMMONFILTERS")]
		public virtual string? CommonFilters { get; set; }

		[InverseProperty("ThePDashboardUser")]
		public virtual List<Anu.PunishmentOrg.Dashboard.PDashboardUserAccess>? ThePDashboardUserAccessList { get; set; }

		[InverseProperty("ThePDashboardUser")]
		public virtual List<Anu.PunishmentOrg.Dashboard.PDashboardUserCharts>? ThePDashboardUserChartsList { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PDASHBOARDUSER")]
    public partial class PDashboardUser : PDashboardUserBase { }

    }


