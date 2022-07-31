

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.MIS
{
    public abstract class PMISCaseViolationBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

        [ForeignKey("PCASEVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseViolation? ThePCaseViolation { get; set; }

        [ForeignKey("PMISCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCase? ThePMISCase { get; set; }

        [InverseProperty("ThePMISCaseViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseTriple>? ThePMISCaseTripleList { get; set; }

        [InverseProperty("ThePMISCaseViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseViolationProduct>? ThePMISCaseViolationProductList { get; set; }

        [Column("VIOLATIONPRICE")]
        public virtual long? ViolationPrice { get; set; }

        [Column("VIOLATIONPRICEBYCOURT")]
        public virtual long? ViolationPriceByCourt { get; set; }

        [Column("VIOLATIONPRICEBYEXPERT")]
        public virtual long? ViolationPriceByExpert { get; set; }

    }

    [Table("PMISCASEVIOLATION")]
    public partial class PMISCaseViolation : PMISCaseViolationBase
    {
    }
    }