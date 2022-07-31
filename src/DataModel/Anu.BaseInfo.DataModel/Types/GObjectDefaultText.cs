

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GObjectDefaultTextBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("DEFAULTTEXT")]
        public virtual string? DefaultText { get; set; }

        [Unicode(false)]
        [Column("RELATEDRECID")]
        public virtual string? RelatedRecId { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("RELATEDOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedObject { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GOBJECTDEFAULTTEXT")]
    public partial class GObjectDefaultText : GObjectDefaultTextBase
    {
    }
    }