

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Attachment
{
    public abstract class GAttachmentDataBase : BaseInfoEntity<string>
    {

        [Column("DOCFILE")]
        public virtual byte[]? DocFile { get; set; }

    }

    [Table("GATTACHMENTDATA")]
    public partial class GAttachmentData : GAttachmentDataBase
    {
    }
}