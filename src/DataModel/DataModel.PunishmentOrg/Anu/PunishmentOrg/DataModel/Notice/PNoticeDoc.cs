

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Notice
{
    public abstract class PNoticeDocBase : PunishmentOrgEntity<string>
    {

        [Column("RELATEDDOCNO")]
        public virtual string? RelatedDocNo { get; set; }

        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectId { get; set; }

        [ForeignKey("PNOTICEID")]
        public virtual Anu.PunishmentOrg.DataModel.Notice.PNotice? ThePNotice { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

    }

    [Table("PNOTICEDOC")]
    public partial class PNoticeDoc : PNoticeDocBase
    {
    }
}