using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportPersonBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Column("DAMAGECAUSEDVALUE")]
        public virtual long? DamageCausedValue { get; set; }

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

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Unicode(false)]
        [Column("POSTCODE")]
        public virtual string? PostCode { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [ForeignKey("NATIONALITYLOCID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheNationalityLoc { get; set; }

        [ForeignKey("PINSPECTIONREPORTID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

        }

    [Table("PINSPECTIONREPORTPERSON")]
    public partial class PInspectionReportPerson : PInspectionReportPersonBase
    {
    }
    }