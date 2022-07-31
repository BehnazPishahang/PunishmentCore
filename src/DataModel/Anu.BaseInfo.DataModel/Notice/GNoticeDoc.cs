

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Notice
{
    public abstract class GNoticeDocBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("RELATEDNOTICEDOCDESC")]
        public virtual string? RelatedNoticeDocDesc { get; set; }

        [Unicode(false)]
        [Column("RELATEDNOTICEDOCNO")]
        public virtual string? RelatedNoticeDocNo { get; set; }

        [Unicode(false)]
        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectID { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

    }

    [Table("GNOTICEDOC")]
    public partial class GNoticeDoc : GNoticeDocBase
    {
    }
    }