using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.PunishmentOrg.DataModel.DiscoveryMinutes;


namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqDocBase : PChaseLicenseReqObject
    {

        [Unicode(false)]
        [Column("DOCDATE")]
        public virtual string? DocDate { get; set; }

        [Unicode(false)]
        [Column("DOCNO")]
        public virtual string? DocNo { get; set; }

        [Unicode(false)]
        [Column("DOCTITLE")]
        public virtual string? DocTitle { get; set; }

        [Unicode(false)]
        [Column("ISSUERUNIT")]
        public virtual string? IssuerUnit { get; set; }

        [Column("ISSUETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.DocIssueType? IssueType { get; set; }

        [Column("OWNERSHIPTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnershipType? OwnershipType { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PCHASELICENSEREQDOC")]
    public partial class PChaseLicenseReqDoc : PChaseLicenseReqDocBase
    {
    }
    }