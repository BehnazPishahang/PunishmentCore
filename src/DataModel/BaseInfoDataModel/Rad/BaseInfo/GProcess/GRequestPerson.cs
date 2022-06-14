

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestPersonBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("EMAILADDRESS")]
		public virtual string? EmailAddress { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("HELPERFIELD1")]
		public virtual string? HelperField1 { get; set; }

		[Column("HELPERFIELD2")]
		public virtual string? HelperField2 { get; set; }

		[Column("HELPERFIELD3")]
		public virtual string? HelperField3 { get; set; }

		[Column("HELPERFIELD4")]
		public virtual string? HelperField4 { get; set; }

		[Column("IDENTITYNO")]
		public virtual string? IdentityNo { get; set; }

		[Column("ISSUEPLACE")]
		public virtual string? IssuePlace { get; set; }

		[Column("MOBILENO")]
		public virtual string? MobileNo { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALITYCODE")]
		public virtual string? NationalityCode { get; set; }

		[Column("PERSONTYPE")]
		public virtual Rad.CMS.Enumerations.PersonType? PersonType { get; set; }

		[Column("POSTCODE")]
		public virtual string? PostCode { get; set; }

		[Column("SERIALNO")]
		public virtual string? SerialNo { get; set; }

		[Column("SERINO")]
		public virtual string? SeriNo { get; set; }

		[Column("SEX")]
		public virtual Rad.CMS.Enumerations.SexType? Sex { get; set; }

		[Column("TELNO")]
		public virtual string? TelNo { get; set; }

		[ForeignKey("BIRTHLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheBirthLocation { get; set; }

		[ForeignKey("CURRENTCITYID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheCurrentCity { get; set; }

		[ForeignKey("GPERSONTYPEID")]
		public virtual Rad.BaseInfo.GProcess.GPersonType? TheGPersonType { get; set; }

		[ForeignKey("GREQUESTID")]
		public virtual Rad.BaseInfo.GProcess.GRequest? TheGRequest { get; set; }

		[ForeignKey("ISSUELOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheIssueLocation { get; set; }

		[ForeignKey("NATIONALITYID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheNationality { get; set; }

    }
    [Table("GREQUESTPERSON")]
    public partial class GRequestPerson : GRequestPersonBase { }

    }


