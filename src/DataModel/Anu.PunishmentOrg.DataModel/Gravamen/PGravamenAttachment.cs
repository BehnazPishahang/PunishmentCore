using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.Attachment;


namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PGravamenAttachmentBase : GAttachment
    {

        [ForeignKey("PGRAVAMENID")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PGravamen? ThePGravamen { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PGRAVAMENATTACHMENT")]
    public partial class PGravamenAttachment : PGravamenAttachmentBase
    {
    }
    }