

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.MIS
{
    public abstract class PMISCaseViolationBase : PunishmentOrgEntity<string>
    {

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBViolationType? ThePBViolationType { get; set; }

		[ForeignKey("PCASEVIOLATIONID")]
		public virtual Anu.PunishmentOrg.Case.PCaseViolation? ThePCaseViolation { get; set; }

		[ForeignKey("PMISCASEID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCase? ThePMISCase { get; set; }

		[InverseProperty("ThePMISCaseViolation")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseTriple>? ThePMISCaseTripleList { get; set; }

		[InverseProperty("ThePMISCaseViolation")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseViolationProduct>? ThePMISCaseViolationProductList { get; set; }

		[Column("VIOLATIONPRICE")]
		public virtual long? ViolationPrice { get; set; }

		[Column("VIOLATIONPRICEBYCOURT")]
		public virtual long? ViolationPriceByCourt { get; set; }

		[Column("VIOLATIONPRICEBYEXPERT")]
		public virtual long? ViolationPriceByExpert { get; set; }

    }
    [Table("PMISCASEVIOLATION")]
    public partial class PMISCaseViolation : PMISCaseViolationBase { }

    }


