

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Dashboard
{
    public abstract class PDashboardUserAccessBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("FROMDATETIME")]
        public virtual string? FromDateTime { get; set; }

        [ForeignKey("PBDASHBOARDCHARTID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBDashboardChart? ThePBDashboardChart { get; set; }

        [ForeignKey("PDASHBOARDUSERID")]
        public virtual Anu.PunishmentOrg.DataModel.Dashboard.PDashboardUser? ThePDashboardUser { get; set; }

        [Unicode(false)]
        [Column("TODATETIME")]
        public virtual string? ToDateTime { get; set; }

    }

    [Table("PDASHBOARDUSERACCESS")]
    public partial class PDashboardUserAccess : PDashboardUserAccessBase
    {
    }
    }