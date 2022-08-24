using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Tablet
{
    public abstract class PTabletsBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("FROMDATETIME")]
        public virtual string? FromDateTime { get; set; }

        [Unicode(false)]
        [Column("LASTSYNCDATETIME")]
        public virtual string? LastSyncDateTime { get; set; }

        [Unicode(false)]
        [Column("SERIALNO")]
        public virtual string? SerialNo { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Unicode(false)]
        [Column("TODATETIME")]
        public virtual string? ToDateTime { get; set; }

        }

    [Table("PTABLETS")]
    public partial class PTablets : PTabletsBase
    {
    }
    }