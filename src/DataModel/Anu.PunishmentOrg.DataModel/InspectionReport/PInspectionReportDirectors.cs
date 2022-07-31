

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportDirectorsBase : PunishmentOrgEntity<string>
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

        [Unicode(false)]
        [Column("OTHERPOST")]
        public virtual string? OtherPost { get; set; }

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

        [Unicode(false)]
        [Column("POSTCODE")]
        public virtual string? PostCode { get; set; }

        [Unicode(false)]
        [Column("POSTCODERN")]
        public virtual string? PostCodeRN { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [ForeignKey("NATIONALITYLOCID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheNationalityLoc { get; set; }

        [ForeignKey("PINSPECTIONREPORTID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

        [InverseProperty("ThePInspectionReportDirectors")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportPost>? ThePInspectionReportPostList { get; set; }

    }

    [Table("PINSPECTIONREPORTDIRECTORS")]
    public partial class PInspectionReportDirectors : PInspectionReportDirectorsBase
    {
    }
    }