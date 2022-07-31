

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Dashboard
{
    public abstract class PDashboardUserChartsBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CHARTFILTERS")]
        public virtual string? ChartFilters { get; set; }

        [Unicode(false)]
        [Column("CHARTPARAMETERS")]
        public virtual string? ChartParameters { get; set; }

        [Column("CHARTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUChartType? ChartType { get; set; }

        [Column("ROWNO")]
        public virtual long? RowNo { get; set; }

        [ForeignKey("PBDASHBOARDCHARTID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBDashboardChart? ThePBDashboardChart { get; set; }

        [ForeignKey("PDASHBOARDUSERID")]
        public virtual Anu.PunishmentOrg.DataModel.Dashboard.PDashboardUser? ThePDashboardUser { get; set; }

    }

    [Table("PDASHBOARDUSERCHARTS")]
    public partial class PDashboardUserCharts : PDashboardUserChartsBase
    {
    }
    }