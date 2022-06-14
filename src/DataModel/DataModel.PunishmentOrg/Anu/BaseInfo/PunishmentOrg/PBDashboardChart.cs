

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBDashboardChartBase : PunishmentOrgEntity<string>
    {

		[Column("CHARTATTRIBUTES")]
		public virtual string? ChartAttributes { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("QUERY")]
		public virtual string? Query { get; set; }

		[Column("QUERYPARAMETERS")]
		public virtual string? QueryParameters { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBDASHBOARDCHART")]
    public partial class PBDashboardChart : PBDashboardChartBase { }

    }


