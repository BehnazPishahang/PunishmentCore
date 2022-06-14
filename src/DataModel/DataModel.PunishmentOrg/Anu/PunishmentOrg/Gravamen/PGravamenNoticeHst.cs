

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Gravamen
{
    public abstract class PGravamenNoticeHstBase : PunishmentOrgEntity<string>
    {

		[Column("ISSUEDATETIME")]
		public virtual string? IssueDateTime { get; set; }

		[Column("NOTICETEXT")]
		public virtual string? NoticeText { get; set; }

		[Column("NOTICETYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.GravamenNoticeType? NoticeType { get; set; }

		[ForeignKey("PGRAVAMENID")]
		public virtual Anu.PunishmentOrg.Gravamen.PGravamen? ThePGravamen { get; set; }

    }
    [Table("PGRAVAMENNOTICEHST")]
    public partial class PGravamenNoticeHst : PGravamenNoticeHstBase { }

    }


