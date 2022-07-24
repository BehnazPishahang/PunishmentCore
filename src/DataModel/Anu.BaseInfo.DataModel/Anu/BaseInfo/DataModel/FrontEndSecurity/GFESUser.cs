

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESUserBase : BaseInfoEntity<string>
    {

        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("LASTCHANGEPASSWORD")]
        public virtual string? LastChangePassword { get; set; }

        [Column("MOBILENUMBER4SMS")]
        public virtual string? MobileNumber4SMS { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALITYCODE")]
        public virtual string? NationalityCode { get; set; }

        [Column("PASSWORD")]
        public virtual string? Password { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [InverseProperty("TheGFESUser")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess>? TheGFESUserAccessList { get; set; }

        [Column("USERID")]
        [Microsoft.EntityFrameworkCore.Unicode(false)]
        public virtual string? UserID { get; set; }

    }

    [Table("GFESUSER")]
    public partial class GFESUser : GFESUserBase
    {
    }
}