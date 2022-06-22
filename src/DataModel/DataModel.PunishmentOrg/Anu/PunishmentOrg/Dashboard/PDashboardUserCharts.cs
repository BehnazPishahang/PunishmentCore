

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Dashboard
{
    public abstract class PDashboardUserChartsBase : PunishmentOrgEntity<string>
    {

		[Column("CHARTFILTERS")]
		public virtual string? ChartFilters { get; set; }

		[Column("CHARTPARAMETERS")]
		public virtual string? ChartParameters { get; set; }

		[Column("CHARTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUChartType? ChartType { get; set; }

		[Column("ROWNO")]
		public virtual long? RowNo { get; set; }

		[ForeignKey("PBDASHBOARDCHARTID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBDashboardChart? ThePBDashboardChart { get; set; }

		[ForeignKey("PDASHBOARDUSERID")]
		public virtual Anu.PunishmentOrg.Dashboard.PDashboardUser? ThePDashboardUser { get; set; }

    }
    [Table("PDASHBOARDUSERCHARTS")]
    public partial class PDashboardUserCharts : PDashboardUserChartsBase { }

    }


