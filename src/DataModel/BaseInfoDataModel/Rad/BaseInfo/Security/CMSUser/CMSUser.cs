

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.CMSUser
{
    public abstract class CMSUserBase : BaseInfoEntity<string>
    {

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("LASTCHANGEPASSWORD")]
		public virtual string? LastChangePassword { get; set; }

		[Column("MOBILENUMBER4SMS")]
		public virtual string? MobileNumber4SMS { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("OLDUSERTITLE")]
		public virtual string? OldUserTitle { get; set; }

		[Column("PASSWORD")]
		public virtual string? Password { get; set; }

		[Column("SALT")]
		public virtual string? Salt { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("EMPLOYEEID")]
		public virtual Rad.BaseInfo.OrganizationChart.Employee? TheEmployee { get; set; }

		[ForeignKey("INDIVIDUALID")]
		public virtual Rad.BaseInfo.Individual.Individual? TheIndividual { get; set; }

		[InverseProperty("TheCMSUser")]
		public virtual List<Rad.BaseInfo.SystemConfiguration.RegisterUserHistory>? TheRegisterUserHistoryList { get; set; }

		[InverseProperty("TheCMSUser")]
		public virtual List<Rad.BaseInfo.Security.CMSUser.UserSecurity>? TheUserSecurityList { get; set; }

		[Column("USERBIRTHDATE")]
		public virtual string? UserBirthDate { get; set; }

		[Column("USERFAMILY")]
		public virtual string? UserFamily { get; set; }

		[Column("USERFATHERNAME")]
		public virtual string? UserFatherName { get; set; }

		[Column("USERISCHECKNATIONALITYCODE")]
		public virtual Rad.CMS.Enumerations.CheckNatinalityStatus? UserIsCheckNationalityCode { get; set; }

		[Column("USERNAME")]
		public virtual string? UserName { get; set; }

		[Column("USERNATIONALITYCODE")]
		public virtual string? UserNationalityCode { get; set; }

		[Column("USERPIC")]
		public virtual byte[]? UserPic { get; set; }

		[Column("USERSEX")]
		public virtual Rad.CMS.Enumerations.SexType? UserSex { get; set; }

		[Column("USERSIGNPIC")]
		public virtual byte[]? UserSignPic { get; set; }

		[Column("USERTITLE")]
		public virtual string? UserTitle { get; set; }

		[Column("USERTYPE")]
		public virtual Rad.CMS.Enumerations.UserType? UserType { get; set; }

    }
    [Table("CMSUSER")]
    public partial class CMSUser : CMSUserBase { }

    }


