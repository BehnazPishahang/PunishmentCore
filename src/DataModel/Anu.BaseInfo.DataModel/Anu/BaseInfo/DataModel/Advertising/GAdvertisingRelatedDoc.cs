

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Advertising
{
    public abstract class GAdvertisingRelatedDocBase : BaseInfoEntity<string>
    {

        [Column("RELATEDDOCID")]
        public virtual string? RelatedDocID { get; set; }

        [Column("RELATEDDOCNO")]
        public virtual string? RelatedDocNo { get; set; }

        [ForeignKey("GADVERTISINGID")]
        public virtual Anu.BaseInfo.DataModel.Advertising.GAdvertising? TheGAdvertising { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

    }

    [Table("GADVERTISINGRELATEDDOC")]
    public partial class GAdvertisingRelatedDoc : GAdvertisingRelatedDocBase
    {
    }
}