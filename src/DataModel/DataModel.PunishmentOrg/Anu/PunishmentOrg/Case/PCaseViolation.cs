

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PCaseViolationBase : PunishmentOrgEntity<string>
    {

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBViolationType? ThePBViolationType { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePCaseViolation")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseProductViolation>? ThePCaseProductViolationList { get; set; }

		[InverseProperty("ThePCaseViolation")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseTriple>? ThePCaseTripleList { get; set; }

		[Column("VIOLATIONADDRESS")]
		public virtual string? ViolationAddress { get; set; }

		[Column("VIOLATIONDATE")]
		public virtual string? ViolationDate { get; set; }

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
    public partial class PCaseViolation : PCaseViolationBase { }

    }


