

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class AttachmentTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

    }

    [Table("ATTACHMENTTYPE")]
    public partial class AttachmentType : AttachmentTypeBase
    {
    }
}