

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBDashboardChartBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CHARTATTRIBUTES")]
        public virtual string? ChartAttributes { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("QUERY")]
        public virtual string? Query { get; set; }

        [Unicode(false)]
        [Column("QUERYPARAMETERS")]
        public virtual string? QueryParameters { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBDASHBOARDCHART")]
    public partial class PBDashboardChart : PBDashboardChartBase
    {
    }
    }