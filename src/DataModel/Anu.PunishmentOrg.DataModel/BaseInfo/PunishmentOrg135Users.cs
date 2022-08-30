using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;



namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PunishmentOrg135UsersBase : Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser
    {

        [Unicode(false)]
        [Column("DYNOMICPASSWORD")]
        public virtual string? DynomicPassword { get; set; }

        [Unicode(false)]
        [Column("SENDDYNOMICPASSWORD")]
        public virtual string? SendDynomicPassword { get; set; }

        [InverseProperty("ThePunishmentOrg135Users")]
        public virtual List<Anu.PunishmentOrg.DataModel.BaseInfo.Users135LoginHistory>? TheUsers135LoginHistoryList { get; set; }

        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set { } }

    }

    [Table("PUNISHMENTORG135USERS")]
    public partial class PunishmentOrg135Users : PunishmentOrg135UsersBase
    {
    }
    }