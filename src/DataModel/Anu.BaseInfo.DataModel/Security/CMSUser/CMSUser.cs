

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Security.CMSUser
{
    public abstract class CMSUserBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Unicode(false)]
        [Column("LASTCHANGEPASSWORD")]
        public virtual string? LastChangePassword { get; set; }

        [Unicode(false)]
        [Column("MOBILENUMBER4SMS")]
        public virtual string? MobileNumber4SMS { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("OLDUSERTITLE")]
        public virtual string? OldUserTitle { get; set; }

        [Unicode(false)]
        [Column("PASSWORD")]
        public virtual string? Password { get; set; }

        [Unicode(false)]
        [Column("SALT")]
        public virtual string? Salt { get; set; }

        [Unicode(false)]
        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [ForeignKey("CASESERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

        [ForeignKey("EMPLOYEEID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Employee? TheEmployee { get; set; }

        [InverseProperty("TheCMSUser")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory>? TheRegisterUserHistoryList { get; set; }

        [Unicode(false)]
        [Column("USERBIRTHDATE")]
        public virtual string? UserBirthDate { get; set; }

        [Unicode(false)]
        [Column("USERFAMILY")]
        public virtual string? UserFamily { get; set; }

        [Unicode(false)]
        [Column("USERFATHERNAME")]
        public virtual string? UserFatherName { get; set; }

        [Column("USERISCHECKNATIONALITYCODE")]
        public virtual Anu.BaseInfo.Enumerations.CheckNatinalityStatus? UserIsCheckNationalityCode { get; set; }

        [Unicode(false)]
        [Column("USERNAME")]
        public virtual string? UserName { get; set; }

        [Unicode(false)]
        [Column("USERNATIONALITYCODE")]
        public virtual string? UserNationalityCode { get; set; }

        [Column("USERPIC")]
        public virtual byte[]? UserPic { get; set; }

        [Column("USERSEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? UserSex { get; set; }

        [Column("USERSIGNPIC")]
        public virtual byte[]? UserSignPic { get; set; }

        [Unicode(false)]
        [Column("USERTITLE")]
        public virtual string? UserTitle { get; set; }

        [Column("USERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.UserType? UserType { get; set; }

    }

    [Table("CMSUSER")]
    public partial class CMSUser : CMSUserBase
    {
    }
    }