

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class ChangeLogCaseBase : BaseInfoEntity<string>
    {

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseId { get; set; }

        [ForeignKey("CASESYSTEMOBJECTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheCaseSystemObjectType { get; set; }

        [ForeignKey("CHANGELOGID")]
        public virtual Anu.BaseInfo.DataModel.DBLoging.ChangeLog? TheChangeLog { get; set; }

    }

    [Table("CHANGELOGCASE")]
    public partial class ChangeLogCase : ChangeLogCaseBase
    {
    }
}