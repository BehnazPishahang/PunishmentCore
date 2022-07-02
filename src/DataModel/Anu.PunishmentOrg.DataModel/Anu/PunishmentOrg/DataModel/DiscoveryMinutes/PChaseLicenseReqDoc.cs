

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
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
        public virtual Anu.PunishmentOrg.Enumerations.DocIssueType? IssueType { get; set; }

        [Column("OWNERSHIPTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnershipType? OwnershipType { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

    }

    [Table("PCHASELICENSEREQDOC")]
    public partial class PChaseLicenseReqDoc : PChaseLicenseReqDocBase
    {
    }
}