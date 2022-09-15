using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Attachment
{
    public abstract class GAttachmentDataBase : BaseInfoEntity<string>
    {
        [Column("DOCFILE", TypeName = "BLOB")]
        public virtual byte[]? DocFile { get; set; }

    }

    [Table("GATTACHMENTDATA")]
    public partial class GAttachmentData : GAttachmentDataBase
    {
    }
}