

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Gravamen
{
    public abstract class PGravamenAttachmentBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PGRAVAMENID")]
		public virtual Anu.PunishmentOrg.Gravamen.PGravamen? ThePGravamen { get; set; }

    }
    [Table("PGRAVAMENATTACHMENT")]
    public partial class PGravamenAttachment : PGravamenAttachmentBase { }

    }


