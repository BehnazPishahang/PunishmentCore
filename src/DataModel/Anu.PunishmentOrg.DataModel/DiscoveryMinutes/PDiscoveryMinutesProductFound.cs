

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesProductFoundBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("BILLNOPRODUCTFOUND")]
        public virtual string? BillNoProductFound { get; set; }

        [Unicode(false)]
        [Column("BRANDNAME")]
        public virtual string? BrandName { get; set; }

        [Column("BRANDNAMERN")]
        public virtual Anu.PunishmentOrg.Enumerations.BrandName? BrandNameRN { get; set; }

        [Column("CONTRABANDPRODUCTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.ContrabandProductType? ContrabandProductType { get; set; }

        [Column("COUNT")]
        public virtual decimal? Count { get; set; }

        [Unicode(false)]
        [Column("COUNTRYCREATE")]
        public virtual string? CountryCreate { get; set; }

        [Column("COUNTRYCREATERN")]
        public virtual Anu.PunishmentOrg.Enumerations.CountryCreate? CountryCreateRN { get; set; }

        [Unicode(false)]
        [Column("CURRENCYUNIT")]
        public virtual string? CurrencyUnit { get; set; }

        [Column("CURRENCYVALUE")]
        public virtual long? CurrencyValue { get; set; }

        [Column("ESTIMATEDVALUE")]
        public virtual decimal? EstimatedValue { get; set; }

        [Unicode(false)]
        [Column("GENERALPRODUCTID")]
        public virtual string? GeneralProductID { get; set; }

        [Unicode(false)]
        [Column("IDNUMBER")]
        public virtual string? IDNumber { get; set; }

        [Column("IDNUMBERRN")]
        public virtual Anu.PunishmentOrg.Enumerations.IDNumber? IDNumberRN { get; set; }

        [Unicode(false)]
        [Column("OTHERINFO")]
        public virtual string? OtherInfo { get; set; }

        [Column("PRODUCTORCURRENCY")]
        public virtual Anu.PunishmentOrg.Enumerations.PProductOrCurrency? ProductOrCurrency { get; set; }

        [Column("PRODUCTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PProductType? ProductType { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Unicode(false)]
        [Column("SERIALNUMBER")]
        public virtual string? SerialNumber { get; set; }

        [Column("SERIALNUMBERRN")]
        public virtual Anu.PunishmentOrg.Enumerations.SerialNumber? SerialNumberRN { get; set; }

        [Unicode(false)]
        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBBILLMEASUREMENTUNITTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBillMeasurementUnitType? ThePBBillMeasurementUnitType { get; set; }

        [ForeignKey("PBBILLPRODUCTGRPID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBillProductGrp? ThePBBillProductGrp { get; set; }

        [InverseProperty("ThePDiscoveryMinutesProductFnd")]
        public virtual List<Anu.PunishmentOrg.DataModel.BillStore.PBillStoreProductDiscovery>? ThePBillStoreProductDiscoveryList { get; set; }

        [ForeignKey("PBPRODUCTCURRENCYTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }

    [Table("PDISCOVERYMINUTESPRODUCTFOUND")]
    public partial class PDiscoveryMinutesProductFound : PDiscoveryMinutesProductFoundBase
    {
    }
    }