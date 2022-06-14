

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Tablet
{
    public abstract class PTabletsBase : PunishmentOrgEntity<string>
    {

		[Column("FROMDATETIME")]
		public virtual string? FromDateTime { get; set; }

		[Column("LASTSYNCDATETIME")]
		public virtual string? LastSyncDateTime { get; set; }

		[Column("SERIALNO")]
		public virtual string? SerialNo { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TODATETIME")]
		public virtual string? ToDateTime { get; set; }

    }
    [Table("PTABLETS")]
    public partial class PTablets : PTabletsBase { }

    }


