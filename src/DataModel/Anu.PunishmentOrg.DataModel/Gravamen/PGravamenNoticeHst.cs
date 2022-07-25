

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PGravamenNoticeHstBase : PunishmentOrgEntity<string>
    {

        [Column("ISSUEDATETIME")]
        public virtual string? IssueDateTime { get; set; }

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