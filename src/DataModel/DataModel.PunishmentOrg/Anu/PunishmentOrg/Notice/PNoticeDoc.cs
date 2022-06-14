

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Notice
{
    public abstract class PNoticeDocBase : PunishmentOrgEntity<string>
    {

		[Column("RELATEDDOCNO")]
		public virtual string? RelatedDocNo { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("PNOTICEID")]
		public virtual Anu.PunishmentOrg.Notice.PNotice? ThePNotice { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("PNOTICEDOC")]
    public partial class PNoticeDoc : PNoticeDocBase { }

    }


