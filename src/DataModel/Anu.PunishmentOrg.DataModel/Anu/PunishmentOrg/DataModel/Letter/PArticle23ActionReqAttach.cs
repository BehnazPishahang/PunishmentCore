

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PArticle23ActionReqAttachBase : PunishmentOrgEntity<string>
    {

        [Column("ATTACHDATE")]
        public virtual string? AttachDate { get; set; }

        [Column("ATTACHDESC")]
        public virtual string? AttachDesc { get; set; }

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