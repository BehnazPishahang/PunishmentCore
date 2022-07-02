

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GObjectDefaultTextBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("DEFAULTTEXT")]
        public virtual string? DefaultText { get; set; }

        [Column("RELATEDRECID")]
        public virtual string? RelatedRecId { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("RELATEDOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedObject { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GOBJECTDEFAULTTEXT")]
    public partial class GObjectDefaultText : GObjectDefaultTextBase
    {
    }
}