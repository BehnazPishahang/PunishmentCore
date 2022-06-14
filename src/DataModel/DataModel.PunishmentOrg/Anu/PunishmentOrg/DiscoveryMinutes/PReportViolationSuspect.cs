

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PReportViolationSuspectBase : PunishmentOrgEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("IDENTITYNUMBER")]
		public virtual string? IdentityNumber { get; set; }

		[Column("MOBILNUMBER")]
		public virtual string? MobilNumber { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("NATIONALITY")]
		public virtual Anu.Enumerations.LNationality? Nationality { get; set; }

		[Column("PASSPORTNO")]
		public virtual string? PassportNo { get; set; }

		[Column("PHONENUMBER")]
		public virtual string? PhoneNumber { get; set; }

		[Column("POSTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PSuspectPostType? PostType { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[ForeignKey("PREPORTVIOLATIONID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

    }
    [Table("PREPORTVIOLATIONSUSPECT")]
    public partial class PReportViolationSuspect : PReportViolationSuspectBase { }

    }


