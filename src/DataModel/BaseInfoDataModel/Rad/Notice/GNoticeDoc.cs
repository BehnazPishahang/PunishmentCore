

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Notice
{
    public abstract class GNoticeDocBase : BaseInfoEntity<string>
    {

		[Column("RELATEDNOTICEDOCDESC")]
		public virtual string? RelatedNoticeDocDesc { get; set; }

		[Column("RELATEDNOTICEDOCNO")]
		public virtual string? RelatedNoticeDocNo { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectID { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GNOTICEDOC")]
    public partial class GNoticeDoc : GNoticeDocBase { }

    }


