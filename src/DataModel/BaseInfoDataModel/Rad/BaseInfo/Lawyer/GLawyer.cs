

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Lawyer
{
    public abstract class GLawyerBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATE")]
		public virtual string? CreateDate { get; set; }

		[Column("EMAILADDRESS")]
		public virtual string? EMailAddress { get; set; }

		[Column("ENDCREDITLICENSEDATE")]
		public virtual string? EndCreditLicenseDate { get; set; }

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("ENDNOVITIATEDATE")]
		public virtual string? EndNovitiateDate { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("HOMEADDRESS")]
		public virtual string? HomeAddress { get; set; }

		[Column("IDENTITYNO")]
		public virtual string? IdentityNo { get; set; }

		[Column("ISDELETED")]
		public virtual Rad.CMS.Enumerations.YesNo? IsDeleted { get; set; }

		[Column("JOBADDRESS")]
		public virtual string? JobAddress { get; set; }

		[Column("JOBTEL")]
		public virtual string? JobTel { get; set; }

		[Column("LAWYERDEGREE")]
		public virtual Rad.CMS.Enumerations.LawyerDegree? LawyerDegree { get; set; }

		[Column("LAWYERSTATE")]
		public virtual Rad.CMS.Enumerations.LawyerState? LawyerState { get; set; }

		[Column("LAWYERTYPELICENSE")]
		public virtual Rad.CMS.Enumerations.LawyerTypeLicense? LawyerTypeLicense { get; set; }

		[Column("LAWYERWORKNO")]
		public virtual string? LawyerWorkNo { get; set; }

		[Column("MARIAGESTATE")]
		public virtual Rad.CMS.Enumerations.MarriageState? MariageState { get; set; }

		[Column("MOBILENUMBER4SMS")]
		public virtual string? MobileNumber4SMS { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALITYCODE")]
		public virtual string? NationalityCode { get; set; }

		[Column("PERSONPASSWORD")]
		public virtual string? PersonPassword { get; set; }

		[Column("SEX")]
		public virtual Rad.CMS.Enumerations.SexType? Sex { get; set; }

		[Column("SOURCEID")]
		public virtual string? SourceID { get; set; }

		[Column("TEL")]
		public virtual string? Tel { get; set; }

		[ForeignKey("ADDRESSLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheAddressLocation { get; set; }

		[ForeignKey("GLAWYERCLUBID")]
		public virtual Rad.BaseInfo.Lawyer.GLawyerClub? TheGLawyerClub { get; set; }

		[InverseProperty("TheGLawyer")]
		public virtual List<Rad.BaseInfo.Lawyer.GLawyerWorkHistory>? TheGLawyerWorkHistoryList { get; set; }

		[ForeignKey("INDIVIDUALID")]
		public virtual Rad.BaseInfo.Individual.Individual? TheIndividual { get; set; }

		[ForeignKey("ISSUELOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheIssueLocation { get; set; }

    }
    [Table("GLAWYER")]
    public partial class GLawyer : GLawyerBase { }

    }


