

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Letter
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
		public virtual DataModel.BaseInfo.Anu.Enumerations.FileExtension? DocFileExtention { get; set; }

		[ForeignKey("PARTICLE23ACTIONREQUESTID")]
		public virtual Anu.PunishmentOrg.Letter.PArticle23ActionRequest? ThePArticle23ActionRequest { get; set; }

    }
    [Table("PARTICLE23ACTIONREQATTACH")]
    public partial class PArticle23ActionReqAttach : PArticle23ActionReqAttachBase { }

    }


