

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PArticle23ActionReqAttachBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ATTACHDATE")]
        public virtual string? AttachDate { get; set; }

        [Unicode(false)]
        [Column("ATTACHDESC")]
        public virtual string? AttachDesc { get; set; }

        [Unicode(false)]
        [Column("ATTACNO")]
        public virtual string? AttacNo { get; set; }

        [Column("DOCFILE")]
        public virtual byte[]? DocFile { get; set; }

        [Column("DOCFILEEXTENTION")]
        public virtual Anu.BaseInfo.Enumerations.FileExtension? DocFileExtention { get; set; }

        [ForeignKey("PARTICLE23ACTIONREQUESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PArticle23ActionRequest? ThePArticle23ActionRequest { get; set; }

    }

    [Table("PARTICLE23ACTIONREQATTACH")]
    public partial class PArticle23ActionReqAttach : PArticle23ActionReqAttachBase
    {
    }
    }