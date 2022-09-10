using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBPuoUsersHistoryBase : PunishmentOrgEntity<string>
    {

        [Column("COUNTCODEPERDAY")]
        public virtual long? CountCodePerDay { get; set; }

        [Unicode(false)]
        [Column("DYNOMICPASSWORD")]
        public virtual string? DynomicPassword { get; set; }

        [Unicode(false)]
        [Column("EXPIREDCODEDATETIME")]
        public virtual string? ExpiredCodeDateTime { get; set; }

        [Unicode(false)]
        [Column("SENDCODEDATETIME")]
        public virtual string? SendCodeDateTime { get; set; }

        [ForeignKey("PBPUOUSERSID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBPuoUsers? ThePBPuoUsers { get; set; }

        }

    [Table("PBPUOUSERSHISTORY")]
    public partial class PBPuoUsersHistory : PBPuoUsersHistoryBase
    {
    }
    }