

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.OrganizationChart
{
    public abstract class EmployeeBase : BaseInfoEntity<string>
    {

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("EMPLOYEENUMBER")]
		public virtual string? EmployeeNumber { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("HOMEADDRESS")]
		public virtual string? HomeAddress { get; set; }

		[Column("IDENTITYNO")]
		public virtual string? IdentityNo { get; set; }

		[Column("MARIAGESTATE")]
		public virtual Rad.CMS.Enumerations.MarriageState? MariageState { get; set; }

		[Column("MOBILNUMBER")]
		public virtual string? MobilNumber { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALITYCODE")]
		public virtual string? NationalityCode { get; set; }

		[Column("RELIGION")]
		public virtual Rad.CMS.Enumerations.Religion? Religion { get; set; }

		[Column("SEX")]
		public virtual Rad.CMS.Enumerations.SexType? Sex { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("TEL")]
		public virtual string? Tel { get; set; }

		[ForeignKey("BIRTHLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheBirthLocation { get; set; }

		[InverseProperty("TheEmployee")]
		public virtual List<Rad.BaseInfo.Security.CMSUser.CMSUser>? TheCMSUserList { get; set; }

		[ForeignKey("ISSUELOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheIssueLocation { get; set; }

    }
    [Table("EMPLOYEE")]
    public partial class Employee : EmployeeBase { }

    }


