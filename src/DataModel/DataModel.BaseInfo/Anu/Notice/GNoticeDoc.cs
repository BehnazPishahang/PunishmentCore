

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Notice
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
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GNOTICEDOC")]
    public partial class GNoticeDoc : GNoticeDocBase { }

    }


