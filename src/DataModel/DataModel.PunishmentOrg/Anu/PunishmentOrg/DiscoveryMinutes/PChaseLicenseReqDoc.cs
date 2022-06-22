

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqDocBase : PunishmentOrgEntity<string>
    {

		[Column("DOCDATE")]
		public virtual string? DocDate { get; set; }

		[Column("DOCNO")]
		public virtual string? DocNo { get; set; }

		[Column("DOCTITLE")]
		public virtual string? DocTitle { get; set; }

		[Column("ISSUERUNIT")]
		public virtual string? IssuerUnit { get; set; }

		[Column("ISSUETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.DocIssueType? IssueType { get; set; }

		[Column("OWNERSHIPTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.OwnershipType? OwnershipType { get; set; }

		[ForeignKey("PCHASELICENSEREQID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

    }
    [Table("PCHASELICENSEREQDOC")]
    public partial class PChaseLicenseReqDoc : PChaseLicenseReqDocBase { }

    }


