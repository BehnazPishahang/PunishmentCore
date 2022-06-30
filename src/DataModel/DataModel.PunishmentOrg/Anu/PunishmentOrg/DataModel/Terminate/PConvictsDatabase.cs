

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PConvictsDatabaseBase : PunishmentOrgEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Column("COMPANYTYPE")]
        public virtual string? CompanyType { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("IDENTITYNUMBER")]
        public virtual string? IdentityNumber { get; set; }

        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("NATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("PHONENUMBER")]
        public virtual string? PhoneNumber { get; set; }

        [Column("POSTCODE")]
        public virtual string? PostCode { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [InverseProperty("ThePConvictsDatabase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PConvictsDatabaseJudge>? ThePConvictsDatabaseJudgeList { get; set; }

    }

    [Table("PCONVICTSDATABASE")]
    public partial class PConvictsDatabase : PConvictsDatabaseBase
    {
    }
}