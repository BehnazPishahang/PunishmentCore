

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Individual
{
    public abstract class IndividualBase : BaseInfoEntity<string>
    {

		[Column("ACTIVITYTYPETITLE")]
		public virtual string? ActivityTypeTitle { get; set; }

		[Column("ALLOWEDDATE")]
		public virtual string? AllowedDate { get; set; }

		[Column("CREATEDATE")]
		public virtual string? CreateDate { get; set; }

		[Column("EMAILADDRESS")]
		public virtual string? EMailAddress { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("FAXNO")]
		public virtual string? FaxNo { get; set; }

		[Column("HOMEADDRESS")]
		public virtual string? HomeAddress { get; set; }

		[Column("IDENTITYNO")]
		public virtual string? IdentityNo { get; set; }

		[Column("ISCHECKORGREGISTRATION")]
		public virtual Rad.CMS.Enumerations.YesNo? IsCheckOrgRegistration { get; set; }

		[Column("ISGOVERNMENTALLEGALPERSON")]
		public virtual bool? IsGovernmentalLegalPerson { get; set; }

		[Column("JOBADDRESS")]
		public virtual string? JobAddress { get; set; }

		[Column("JOBTEL")]
		public virtual string? JobTel { get; set; }

		[Column("MARIAGESTATE")]
		public virtual Rad.CMS.Enumerations.MarriageState? MariageState { get; set; }

		[Column("MOBILENUMBER4SMS")]
		public virtual string? MobileNumber4SMS { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALITYCODE")]
		public virtual string? NationalityCode { get; set; }

		[Column("PERSONPASSWORD")]
		public virtual decimal? PersonPassword { get; set; }

		[Column("PERSONTYPE")]
		public virtual Rad.CMS.Enumerations.PersonType? PersonType { get; set; }

		[Column("POSTCODE")]
		public virtual string? PostCode { get; set; }

		[Column("PSEUDONYM")]
		public virtual string? pseudonym { get; set; }

		[Column("RECORDNO")]
		public virtual string? RecordNo { get; set; }

		[Column("RELIGION")]
		public virtual Rad.CMS.Enumerations.Religion? Religion { get; set; }

		[Column("SABTAHVALISUUEPLACE")]
		public virtual string? SabtAhvalIsuuePlace { get; set; }

		[Column("SEX")]
		public virtual Rad.CMS.Enumerations.SexType? Sex { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("TEL")]
		public virtual string? Tel { get; set; }

		[ForeignKey("BASELOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheBaseLocation { get; set; }

		[ForeignKey("BIRTHLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheBirthLocation { get; set; }

		[ForeignKey("CURRENTLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheCurrentLocation { get; set; }

		[ForeignKey("EDUCATIONLEVELID")]
		public virtual Rad.BaseInfo.Types.EducationLevel? TheEducationLevel { get; set; }

		[InverseProperty("TheIndividual")]
		public virtual List<Rad.BaseInfo.Individual.FingerPoint>? TheFingerPointList { get; set; }

		[ForeignKey("GRADUATIONALDEGREEID")]
		public virtual Rad.BaseInfo.Individual.GraduationalDegree? TheGraduationalDegree { get; set; }

		[ForeignKey("ISSUELOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheIssueLocation { get; set; }

		[ForeignKey("JOBTITLEID")]
		public virtual Rad.BaseInfo.Types.JobTitle? TheJobTitle { get; set; }

		[ForeignKey("LEGALPERSONTYPEID")]
		public virtual Rad.BaseInfo.Individual.LegalPersonType? TheLegalPersonType { get; set; }

		[ForeignKey("NATIONALITYID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheNationality { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("INDIVIDUAL")]
    public partial class Individual : IndividualBase { }

    }


