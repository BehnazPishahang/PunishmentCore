

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesProductFoundBase : PunishmentOrgEntity<string>
    {

		[Column("BILLNOPRODUCTFOUND")]
		public virtual string? BillNoProductFound { get; set; }

		[Column("BRANDNAME")]
		public virtual string? BrandName { get; set; }

		[Column("BRANDNAMERN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.BrandName? BrandNameRN { get; set; }

		[Column("CONTRABANDPRODUCTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.ContrabandProductType? ContrabandProductType { get; set; }

		[Column("COUNT")]
		public virtual decimal? Count { get; set; }

		[Column("COUNTRYCREATE")]
		public virtual string? CountryCreate { get; set; }

		[Column("COUNTRYCREATERN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.CountryCreate? CountryCreateRN { get; set; }

		[Column("CURRENCYUNIT")]
		public virtual string? CurrencyUnit { get; set; }

		[Column("CURRENCYVALUE")]
		public virtual long? CurrencyValue { get; set; }

		[Column("ESTIMATEDVALUE")]
		public virtual decimal? EstimatedValue { get; set; }

		[Column("IDNUMBER")]
		public virtual string? IDNumber { get; set; }

		[Column("IDNUMBERRN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.IDNumber? IDNumberRN { get; set; }

		[Column("OTHERINFO")]
		public virtual string? OtherInfo { get; set; }

		[Column("PRODUCTORCURRENCY")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PProductOrCurrency? ProductOrCurrency { get; set; }

		[Column("PRODUCTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PProductType? ProductType { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SERIALNUMBER")]
		public virtual string? SerialNumber { get; set; }

		[Column("SERIALNUMBERRN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.SerialNumber? SerialNumberRN { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBBILLMEASUREMENTUNITTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBillMeasurementUnitType? ThePBBillMeasurementUnitType { get; set; }

		[ForeignKey("PBBILLPRODUCTGRPID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBillProductGrp? ThePBBillProductGrp { get; set; }

		[InverseProperty("ThePDiscoveryMinutesProductFnd")]
		public virtual List<Anu.PunishmentOrg.BillStore.PBillStoreProductDiscovery>? ThePBillStoreProductDiscoveryList { get; set; }

		[ForeignKey("PBPRODUCTCURRENCYTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

		[ForeignKey("PDISCOVERYMINUTESID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }
    [Table("PDISCOVERYMINUTESPRODUCTFOUND")]
    public partial class PDiscoveryMinutesProductFound : PDiscoveryMinutesProductFoundBase { }

    }


