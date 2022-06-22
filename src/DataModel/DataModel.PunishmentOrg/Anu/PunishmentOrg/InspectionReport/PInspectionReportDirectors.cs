

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.InspectionReport
{
    public abstract class PInspectionReportDirectorsBase : PunishmentOrgEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("ADDRESSRN")]
		public virtual string? AddressRN { get; set; }

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("BIRTHDATERN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.Refuse? BirthDateRN { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("FATHERNAMERN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.Refuse? FatherNameRN { get; set; }

		[Column("FULLNAMERN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.Refuse? FullNameRN { get; set; }

		[Column("IDENTITYNUMBER")]
		public virtual string? IdentityNumber { get; set; }

		[Column("MOBILNUMBER")]
		public virtual string? MobilNumber { get; set; }

		[Column("MOBILNUMBERRN")]
		public virtual string? MobilNumberRN { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("NATIONALCODERN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.Refuse? NationalCodeRN { get; set; }

		[Column("NATIONALITY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.LNationality? Nationality { get; set; }

		[Column("NATIONALITYRN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.Refuse? NationalityRN { get; set; }

		[Column("OTHERPOST")]
		public virtual string? OtherPost { get; set; }

		[Column("PASSPORTNO")]
		public virtual string? PassportNo { get; set; }

		[Column("PASSPORTNORN")]
		public virtual string? PassportNoRN { get; set; }

		[Column("PERSONTYPE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.PersonType? PersonType { get; set; }

		[Column("PHONENUMBER")]
		public virtual string? PhoneNumber { get; set; }

		[Column("PHONENUMBERRN")]
		public virtual string? PhoneNumberRN { get; set; }

		[Column("POSTCODE")]
		public virtual string? PostCode { get; set; }

		[Column("POSTCODERN")]
		public virtual string? PostCodeRN { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? Sex { get; set; }

		[ForeignKey("NATIONALITYLOCID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.GeoInfo.GeoLocation? TheNationalityLoc { get; set; }

		[ForeignKey("PINSPECTIONREPORTID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

		[InverseProperty("ThePInspectionReportDirectors")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReportPost>? ThePInspectionReportPostList { get; set; }

    }
    [Table("PINSPECTIONREPORTDIRECTORS")]
    public partial class PInspectionReportDirectors : PInspectionReportDirectorsBase { }

    }


