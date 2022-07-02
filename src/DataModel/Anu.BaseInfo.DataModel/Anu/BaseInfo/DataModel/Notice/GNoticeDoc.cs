

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Notice
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
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

    }

    [Table("GNOTICEDOC")]
    public partial class GNoticeDoc : GNoticeDocBase
    {
    }
}