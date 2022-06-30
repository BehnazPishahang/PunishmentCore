

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Notice
{
    public abstract class PNoticeAdvertisingDocBase : PunishmentOrgEntity<string>
    {

        [Column("RELATEDDOCNO")]
        public virtual string? RelatedDocNo { get; set; }

        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectId { get; set; }

        [ForeignKey("PNOTICEADVERTISINGID")]
        public virtual Anu.PunishmentOrg.DataModel.Notice.PNoticeAdvertising? ThePNoticeAdvertising { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

    }

    [Table("PNOTICEADVERTISINGDOC")]
    public partial class PNoticeAdvertisingDoc : PNoticeAdvertisingDocBase
    {
    }
}