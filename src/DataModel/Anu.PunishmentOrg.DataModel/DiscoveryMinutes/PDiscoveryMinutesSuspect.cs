using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesSuspectBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("ADDRESSRN")]
        public virtual string? AddressRN { get; set; }

        [Unicode(false)]
        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Column("BIRTHDATERN")]
        public virtual Anu.PunishmentOrg.Enumerations.Refuse? BirthDateRN { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("DISCLAIMERREASON")]
        public virtual string? DisclaimerReason { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("FATHERNAMERN")]
        public virtual Anu.PunishmentOrg.Enumerations.Refuse? FatherNameRN { get; set; }

        [Column("FULLNAMERN")]
        public virtual Anu.PunishmentOrg.Enumerations.Refuse? FullNameRN { get; set; }

        [Unicode(false)]
        [Column("IDENTITYNUMBER")]
        public virtual string? IdentityNumber { get; set; }

        [Unicode(false)]
        [Column("IDENTITYNUMBERRN")]
        public virtual string? IdentityNumberRN { get; set; }

        [Column("ISDISCLAIMER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsDisclaimer { get; set; }

        [Column("ISSEARCHHISTORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsSearchHistory { get; set; }

        [Unicode(false)]
        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Unicode(false)]
        [Column("MOBILNUMBERRN")]
        public virtual string? MobilNumberRN { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("NATIONALCODERN")]
        public virtual Anu.PunishmentOrg.Enumerations.Refuse? NationalCodeRN { get; set; }

        [Column("NATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

        [Column("NATIONALITYRN")]
        public virtual Anu.PunishmentOrg.Enumerations.Refuse? NationalityRN { get; set; }

        [Column("NUMOFHISTORY")]
        public virtual long? NumOfHistory { get; set; }

        [Unicode(false)]
        [Column("PASSPORTNO")]
        public virtual string? PassportNo { get; set; }

        [Unicode(false)]
        [Column("PASSPORTNORN")]
        public virtual string? PassportNoRN { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Unicode(false)]
        [Column("PHONENUMBER")]
        public virtual string? PhoneNumber { get; set; }

        [Unicode(false)]
        [Column("PHONENUMBERRN")]
        public virtual string? PhoneNumberRN { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("NONIRANIANCITIZENSHIPID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheNonIranianCitizenship { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

        [InverseProperty("ThePDiscoveryMinutesSuspect")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesSuspectHst>? ThePDiscoveryMinutesSuspectHstList { get; set; }

        [InverseProperty("ThePDiscoveryMinutesSuspect")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesSuspectPost>? ThePDiscoveryMinutesSuspectPostList { get; set; }

        [InverseProperty("ThePDiscoveryMinutesSuspect")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesSuspectVio>? ThePDiscoveryMinutesSuspectVioList { get; set; }

        }

    [Table("PDISCOVERYMINUTESSUSPECT")]
    public partial class PDiscoveryMinutesSuspect : PDiscoveryMinutesSuspectBase
    {
    }
    }