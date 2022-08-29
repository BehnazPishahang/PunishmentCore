using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseViolationBase : PunishmentOrgEntity<string>
    {

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Unicode(false)]
        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [Unicode(false)]
        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePCaseViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseProductViolation>? ThePCaseProductViolationList { get; set; }

        [InverseProperty("ThePCaseViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseTriple>? ThePCaseTripleList { get; set; }

        [Unicode(false)]
        [Column("VIOLATIONADDRESS")]
        public virtual string? ViolationAddress { get; set; }

        [Unicode(false)]
        [Column("VIOLATIONDATE")]
        public virtual string? ViolationDate { get; set; }

        [Unicode(false)]
        [Column("VIOLATIONDESC")]
        public virtual string? ViolationDesc { get; set; }

        [Column("VIOLATIONPRICE")]
        public virtual long? ViolationPrice { get; set; }

        [Column("VIOLATIONPRICEBYCOURT")]
        public virtual long? ViolationPriceByCourt { get; set; }

        [Column("VIOLATIONPRICEBYEXPERT")]
        public virtual long? ViolationPriceByExpert { get; set; }

        }

    [Table("PCASEVIOLATION")]
    public partial class PCaseViolation : PCaseViolationBase
    {
    }
    }