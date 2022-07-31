

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESUserBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

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
        [Column("NATIONALITYCODE")]
        public virtual string? NationalityCode { get; set; }

        [Unicode(false)]
        [Column("PASSWORD")]
        public virtual string? Password { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [Unicode(false)]
        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [InverseProperty("TheGFESUser")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess>? TheGFESUserAccessList { get; set; }

        [Unicode(false)]
        [Column("USERID")]
        public virtual string? UserID { get; set; }

    }

    [Table("GFESUSER")]
    public partial class GFESUser : GFESUserBase
    {
    }
    }