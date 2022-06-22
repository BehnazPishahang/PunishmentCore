

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqSuspectBase : PunishmentOrgEntity<string>
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
		public virtual DataModel.BaseInfo.Anu.Enumerations.LNationality? Nationality { get; set; }

		[Column("PASSPORTNO")]
		public virtual string? PassportNo { get; set; }

		[Column("PHONENUMBER")]
		public virtual string? PhoneNumber { get; set; }

		[Column("POSTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PSuspectPostType? PostType { get; set; }

		[ForeignKey("NONIRANIANCITIZENSHIPID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.GeoInfo.GeoLocation? TheNonIranianCitizenship { get; set; }

		[ForeignKey("PCHASELICENSEREQID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

		[InverseProperty("ThePChaseLicenseReqSuspect")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqSuspectTyp>? ThePChaseLicenseReqSuspectTypList { get; set; }

    }
    [Table("PCHASELICENSEREQSUSPECT")]
    public partial class PChaseLicenseReqSuspect : PChaseLicenseReqSuspectBase { }

    }


