

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Dashboard
{
    public abstract class PDashboardUserBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Unicode(false)]
        [Column("COMMONFILTERS")]
        public virtual string? CommonFilters { get; set; }

        [InverseProperty("ThePDashboardUser")]
        public virtual List<Anu.PunishmentOrg.DataModel.Dashboard.PDashboardUserAccess>? ThePDashboardUserAccessList { get; set; }

        [InverseProperty("ThePDashboardUser")]
        public virtual List<Anu.PunishmentOrg.DataModel.Dashboard.PDashboardUserCharts>? ThePDashboardUserChartsList { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }

    [Table("PDASHBOARDUSER")]
    public partial class PDashboardUser : PDashboardUserBase
    {
    }
    }