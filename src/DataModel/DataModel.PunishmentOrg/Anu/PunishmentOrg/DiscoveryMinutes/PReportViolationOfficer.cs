

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PReportViolationOfficerBase : PunishmentOrgEntity<string>
    {

		[Column("DEGREE")]
		public virtual string? Degree { get; set; }

		[Column("DISCOVERYUNIT")]
		public virtual string? DiscoveryUnit { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("INSPECTIONCODE")]
		public virtual string? InspectionCode { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("PERSONELNO")]
		public virtual string? PersonelNo { get; set; }

		[Column("SIGNTEXT")]
		public virtual string? SignText { get; set; }

		[Column("SYSTEMNAME")]
		public virtual string? SystemName { get; set; }

		[ForeignKey("PREPORTVIOLATIONID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

    }
    [Table("PREPORTVIOLATIONOFFICER")]
    public partial class PReportViolationOfficer : PReportViolationOfficerBase { }

    }


