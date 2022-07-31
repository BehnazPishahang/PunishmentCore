

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedLicenseBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ARCHIVEADDRESS")]
        public virtual string? ArchiveAddress { get; set; }

        [Column("ARCHIVEAREA")]
        public virtual long? ArchiveArea { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("ISSUEDATE")]
        public virtual string? IssueDate { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("PAGESUM")]
        public virtual long? PageSum { get; set; }

        [Unicode(false)]
        [Column("REQDATE")]
        public virtual string? ReqDate { get; set; }

        [InverseProperty("ThePDestroyedLicense")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedLicenseForms4>? ThePDestroyedLicenseForms4List { get; set; }

        [InverseProperty("ThePDestroyedLicense")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedLicenseImage>? ThePDestroyedLicenseImageList { get; set; }

        [InverseProperty("ThePDestroyedLicense")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedLicensePages>? ThePDestroyedLicensePagesList { get; set; }

        [InverseProperty("ThePDestroyedLicense")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PForm5Minute>? ThePForm5MinuteList { get; set; }

        [ForeignKey("REGISTRARUSERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegistrarUser { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PDESTROYEDLICENSE")]
    public partial class PDestroyedLicense : PDestroyedLicenseBase
    {
    }
    }