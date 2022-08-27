using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PGravamenNoticeHstBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ISSUEDATETIME")]
        public virtual string? IssueDateTime { get; set; }

        [Unicode(false)]
        [Column("NOTICETEXT")]
        public virtual string? NoticeText { get; set; }

        [Column("NOTICETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.GravamenNoticeType? NoticeType { get; set; }

        [ForeignKey("PGRAVAMENID")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PGravamen? ThePGravamen { get; set; }

        }

    [Table("PGRAVAMENNOTICEHST")]
    public partial class PGravamenNoticeHst : PGravamenNoticeHstBase
    {
    }
    }