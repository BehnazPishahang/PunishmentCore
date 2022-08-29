using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class EmployeeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Unicode(false)]
        [Column("EMPLOYEENUMBER")]
        public virtual string? EmployeeNumber { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALITYCODE")]
        public virtual string? NationalityCode { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheEmployee")]
        public virtual List<Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser>? TheCMSUserList { get; set; }

        }

    [Table("EMPLOYEE")]
    public partial class Employee : EmployeeBase
    {
    }
    }