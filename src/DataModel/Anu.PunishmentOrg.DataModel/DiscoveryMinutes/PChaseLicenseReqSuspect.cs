

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqSuspectBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("IDENTITYNUMBER")]
        public virtual string? IdentityNumber { get; set; }

        [Unicode(false)]
        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("NATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

        [Unicode(false)]
        [Column("PASSPORTNO")]
        public virtual string? PassportNo { get; set; }

        [Unicode(false)]
        [Column("PHONENUMBER")]
        public virtual string? PhoneNumber { get; set; }

        [Column("POSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PSuspectPostType? PostType { get; set; }

        [ForeignKey("NONIRANIANCITIZENSHIPID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheNonIranianCitizenship { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

        [InverseProperty("ThePChaseLicenseReqSuspect")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqSuspectTyp>? ThePChaseLicenseReqSuspectTypList { get; set; }

    }

    [Table("PCHASELICENSEREQSUSPECT")]
    public partial class PChaseLicenseReqSuspect : PChaseLicenseReqSuspectBase
    {
    }
    }