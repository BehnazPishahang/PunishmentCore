

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Dashboard
{
    public abstract class PDashboardUserAccessBase : PunishmentOrgEntity<string>
    {

		[Column("FROMDATETIME")]
		public virtual string? FromDateTime { get; set; }

		[ForeignKey("PBDASHBOARDCHARTID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBDashboardChart? ThePBDashboardChart { get; set; }

		[ForeignKey("PDASHBOARDUSERID")]
		public virtual Anu.PunishmentOrg.Dashboard.PDashboardUser? ThePDashboardUser { get; set; }

		[Column("TODATETIME")]
		public virtual string? ToDateTime { get; set; }

    }
    [Table("PDASHBOARDUSERACCESS")]
    public partial class PDashboardUserAccess : PDashboardUserAccessBase { }

    }


