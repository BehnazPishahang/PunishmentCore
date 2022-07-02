

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Dashboard
{
    public abstract class PDashboardUserAccessBase : PunishmentOrgEntity<string>
    {

        [Column("FROMDATETIME")]
        public virtual string? FromDateTime { get; set; }

        [ForeignKey("PBDASHBOARDCHARTID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBDashboardChart? ThePBDashboardChart { get; set; }

        [ForeignKey("PDASHBOARDUSERID")]
        public virtual Anu.PunishmentOrg.DataModel.Dashboard.PDashboardUser? ThePDashboardUser { get; set; }

        [Column("TODATETIME")]
        public virtual string? ToDateTime { get; set; }

    }

    [Table("PDASHBOARDUSERACCESS")]
    public partial class PDashboardUserAccess : PDashboardUserAccessBase
    {
    }
}