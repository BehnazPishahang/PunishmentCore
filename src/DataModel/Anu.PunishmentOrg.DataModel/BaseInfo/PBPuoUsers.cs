using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.FrontEndSecurity;


namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBPuoUsersBase : GFESUser
    {

        [Unicode(false)]
        [Column("BIRTHDAY")]
        public virtual string? BirthDay { get; set; }

        [Unicode(false)]
        [Column("DYNOMICPASSWORD")]
        public virtual string? DynomicPassword { get; set; }

        [Unicode(false)]
        [Column("SENDDYNOMICPASSWORD")]
        public virtual string? SendDynomicPassword { get; set; }

        [InverseProperty("ThePBPuoUsers")]
        public virtual List<Anu.PunishmentOrg.DataModel.BaseInfo.PBPuoUsersHistory>? ThePBPuoUsersHistoryList { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PBPUOUSERS")]
    public partial class PBPuoUsers : PBPuoUsersBase
    {
    }
    }