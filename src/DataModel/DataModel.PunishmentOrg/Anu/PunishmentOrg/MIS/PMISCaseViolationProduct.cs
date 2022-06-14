

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.MIS
{
    public abstract class PMISCaseViolationProductBase : PunishmentOrgEntity<string>
    {

		[Column("CONTRABANDPRODUCTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.ContrabandProductType? ContrabandProductType { get; set; }

		[Column("PRODUCTCURRENCY")]
		public virtual Anu.Enumerations.PunishmentOrg.PUProductCurrency? ProductCurrency { get; set; }

		[Column("PRODUCTVALUE")]
		public virtual long? ProductValue { get; set; }

		[Column("SALEPRICE")]
		public virtual long? SalePrice { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[Column("STANDARDPRICE")]
		public virtual long? StandardPrice { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBPRODUCTCURRENCYTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

		[ForeignKey("PCASEPRODUCTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseProduct? ThePCaseProduct { get; set; }

		[ForeignKey("PMISCASEVIOLATIONID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCaseViolation? ThePMISCaseViolation { get; set; }

    }
    [Table("PMISCASEVIOLATIONPRODUCT")]
    public partial class PMISCaseViolationProduct : PMISCaseViolationProductBase { }

    }


