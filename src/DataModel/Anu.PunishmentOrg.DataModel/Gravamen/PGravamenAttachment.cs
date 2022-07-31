

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PGravamenAttachmentBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PGRAVAMENID")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PGravamen? ThePGravamen { get; set; }

    }

    [Table("PGRAVAMENATTACHMENT")]
    public partial class PGravamenAttachment : PGravamenAttachmentBase
    {
    }
    }