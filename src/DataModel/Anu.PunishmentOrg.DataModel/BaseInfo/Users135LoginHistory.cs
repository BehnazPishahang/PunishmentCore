using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class Users135LoginHistoryBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("EXPIREDCODEDATETIME")]
        public virtual string? ExpiredCodeDateTime { get; set; }

        [Unicode(false)]
        [Column("SENDCODEDATETIME")]
        public virtual string? SendCodeDateTime { get; set; }

        [Column("SENDCODEPERDAY")]
        public virtual long? SendCodePerDay { get; set; }

        [Unicode(false)]
        [Column("SMSCODE")]
        public virtual string? SmsCode { get; set; }

        [ForeignKey("PUNISHMENTORG135USERSID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PunishmentOrg135Users? ThePunishmentOrg135Users { get; set; }

        }

    [Table("USERS135LOGINHISTORY")]
    public partial class Users135LoginHistory : Users135LoginHistoryBase
    {
    }
    }