

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedLicenseBase : PunishmentOrgEntity<string>
    {

		[Column("ARCHIVEADDRESS")]
		public virtual string? ArchiveAddress { get; set; }

		[Column("ARCHIVEAREA")]
		public virtual long? ArchiveArea { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("ISSUEDATE")]
		public virtual string? IssueDate { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PAGESUM")]
		public virtual long? PageSum { get; set; }

		[Column("REQDATE")]
		public virtual string? ReqDate { get; set; }

		[InverseProperty("ThePDestroyedLicense")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedLicenseForms4>? ThePDestroyedLicenseForms4List { get; set; }

		[InverseProperty("ThePDestroyedLicense")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedLicenseImage>? ThePDestroyedLicenseImageList { get; set; }

		[InverseProperty("ThePDestroyedLicense")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedLicensePages>? ThePDestroyedLicensePagesList { get; set; }

		[InverseProperty("ThePDestroyedLicense")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PForm5Minute>? ThePForm5MinuteList { get; set; }

		[ForeignKey("REGISTRARUSERID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegistrarUser { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PDESTROYEDLICENSE")]
    public partial class PDestroyedLicense : PDestroyedLicenseBase { }

    }


