

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.OrganizationChart
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

        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

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