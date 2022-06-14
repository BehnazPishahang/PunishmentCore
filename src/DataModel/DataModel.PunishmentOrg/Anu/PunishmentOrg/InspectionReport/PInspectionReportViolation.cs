

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.InspectionReport
{
    public abstract class PInspectionReportViolationBase : PunishmentOrgEntity<string>
    {

		[Column("AMOUNTNUMBER")]
		public virtual decimal? AmountNumber { get; set; }

		[Column("APPROVEDFAIRGUIDANCEPRICE")]
		public virtual long? ApprovedFairGuidancePrice { get; set; }

		[Column("GOODCODE")]
		public virtual string? GoodCode { get; set; }

		[Column("GOODSIDENTITY")]
		public virtual string? GoodsIdentity { get; set; }

		[Column("GOODSSERVICESNAME")]
		public virtual string? GoodsServicesName { get; set; }

		[Column("INVENTORY")]
		public virtual long? Inventory { get; set; }

		[Column("MONETARYABUSE")]
		public virtual long? MonetaryAbuse { get; set; }

		[Column("PBINSPECTIONVIOTYPOTHER")]
		public virtual string? PBInspectionVioTypOther { get; set; }

		[Column("PERCENTAUTHORIZED")]
		public virtual decimal? PercentAuthorized { get; set; }

		[Column("PURCHASEPRICE")]
		public virtual long? PurchasePrice { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SALESPRICE")]
		public virtual long? SalesPrice { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBINSPECTIONVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBInspectionViolationType? ThePBInspectionViolationType { get; set; }

		[ForeignKey("PBPRODUCTCURRENCYTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

		[ForeignKey("PINSPECTIONREPORTID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

		[InverseProperty("ThePInspectionReportViolation")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReportVioType>? ThePInspectionReportVioTypeList { get; set; }

		[Column("TOTALVALUEGOODS")]
		public virtual long? TotalValueGoods { get; set; }

		[Column("VIOLATIONDESC")]
		public virtual string? ViolationDesc { get; set; }

    }
    [Table("PINSPECTIONREPORTVIOLATION")]
    public partial class PInspectionReportViolation : PInspectionReportViolationBase { }

    }


