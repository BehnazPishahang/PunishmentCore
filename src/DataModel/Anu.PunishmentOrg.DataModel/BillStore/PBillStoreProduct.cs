using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.BillStore
{
    public abstract class PBillStoreProductBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ARTICLE21")]
        public virtual string? Article21 { get; set; }

        [Unicode(false)]
        [Column("BRANDNAME")]
        public virtual string? BrandName { get; set; }

        [Unicode(false)]
        [Column("CARAXLE")]
        public virtual string? CarAxle { get; set; }

        [Unicode(false)]
        [Column("CARBODYNUMBER")]
        public virtual string? CarBodyNumber { get; set; }

        [Unicode(false)]
        [Column("CARCAPACITY")]
        public virtual string? CarCapacity { get; set; }

        [Unicode(false)]
        [Column("CARCHASSISNUMBER")]
        public virtual string? CarChassisNumber { get; set; }

        [Unicode(false)]
        [Column("CARCOLOR")]
        public virtual string? CarColor { get; set; }

        [Unicode(false)]
        [Column("CARCYLINDER")]
        public virtual string? CarCylinder { get; set; }

        [Unicode(false)]
        [Column("CARDOORNUMBER")]
        public virtual string? CarDoorNumber { get; set; }

        [Unicode(false)]
        [Column("CARENGINEVOLUME")]
        public virtual string? CarEngineVolume { get; set; }

        [Unicode(false)]
        [Column("CARENGINNUMBER")]
        public virtual string? CarEnginNumber { get; set; }

        [Unicode(false)]
        [Column("CARFUEL")]
        public virtual string? CarFuel { get; set; }

        [Unicode(false)]
        [Column("CARGEARBOXTYPE")]
        public virtual string? CarGearboxType { get; set; }

        [Column("CARMALFUNCTIONSTATUS")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? CarMalfunctionStatus { get; set; }

        [Unicode(false)]
        [Column("CARMODEL")]
        public virtual string? CarModel { get; set; }

        [Unicode(false)]
        [Column("CARPLAQUE")]
        public virtual string? CarPlaque { get; set; }

        [Unicode(false)]
        [Column("CARPLAQUEDATE")]
        public virtual string? CarPlaqueDate { get; set; }

        [Unicode(false)]
        [Column("CARSTYLE")]
        public virtual string? CarStyle { get; set; }

        [Unicode(false)]
        [Column("CARSYSTEM")]
        public virtual string? CarSystem { get; set; }

        [Unicode(false)]
        [Column("CARTYPE")]
        public virtual string? CarType { get; set; }

        [Unicode(false)]
        [Column("CARUSAGE")]
        public virtual string? CarUsage { get; set; }

        [Unicode(false)]
        [Column("CARWHEEL")]
        public virtual string? CarWheel { get; set; }

        [Unicode(false)]
        [Column("COUNTRYCREATE")]
        public virtual string? CountryCreate { get; set; }

        [Unicode(false)]
        [Column("CURRENCYUNIT")]
        public virtual string? CurrencyUnit { get; set; }

        [Column("CURRENCYVALUE")]
        public virtual long? CurrencyValue { get; set; }

        [Unicode(false)]
        [Column("DISCOVERYROWNUMBERS")]
        public virtual string? DiscoveryRowNumbers { get; set; }

        [Column("ESTIMATEDVALUE")]
        public virtual decimal? EstimatedValue { get; set; }

        [Unicode(false)]
        [Column("EXPIREDATE")]
        public virtual string? ExpireDate { get; set; }

        [Unicode(false)]
        [Column("IDNUMBER")]
        public virtual string? IDNumber { get; set; }

        [Column("ISFIREWOOD")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsFireWood { get; set; }

        [Unicode(false)]
        [Column("JEWELRYCOARSE")]
        public virtual string? JewelryCoarse { get; set; }

        [Unicode(false)]
        [Column("JEWELRYCUT")]
        public virtual string? JewelryCut { get; set; }

        [Unicode(false)]
        [Column("JEWELRYCUTTING")]
        public virtual string? JewelryCutting { get; set; }

        [Unicode(false)]
        [Column("JEWELRYMATERIAL")]
        public virtual string? JewelryMaterial { get; set; }

        [Unicode(false)]
        [Column("JEWELRYWEIGHT")]
        public virtual string? JewelryWeight { get; set; }

        [Unicode(false)]
        [Column("NONESSENTIALPETROLEUMPRODUCT")]
        public virtual string? NonEssentialPetroleumProduct { get; set; }

        [Column("OBJECTARCHAISM")]
        public virtual long? ObjectArchaism { get; set; }

        [Unicode(false)]
        [Column("OBJECTCULTURALVALUE")]
        public virtual string? ObjectCulturalValue { get; set; }

        [Unicode(false)]
        [Column("OBJECTDESC")]
        public virtual string? ObjectDesc { get; set; }

        [Unicode(false)]
        [Column("OBJECTGENDER")]
        public virtual string? ObjectGender { get; set; }

        [Column("OBJECTHEIGHT")]
        public virtual long? ObjectHeight { get; set; }

        [Column("OBJECTIMAGE")]
        public virtual byte[]? ObjectImage { get; set; }

        [Column("OBJECTLENGTH")]
        public virtual long? ObjectLength { get; set; }

        [Column("OBJECTORIGINALITY")]
        public virtual Anu.PunishmentOrg.Enumerations.ObjectOriginality? ObjectOriginality { get; set; }

        [Column("OBJECTWIDTH")]
        public virtual long? ObjectWidth { get; set; }

        [Unicode(false)]
        [Column("PACKINGTYPE")]
        public virtual string? PackingType { get; set; }

        [Column("PRIMERYVALUE")]
        public virtual decimal? PrimeryValue { get; set; }

        [Unicode(false)]
        [Column("PRODUCTDESC")]
        public virtual string? ProductDesc { get; set; }

        [Unicode(false)]
        [Column("PRODUCTMAINGRADE")]
        public virtual string? ProductMainGrade { get; set; }

        [Unicode(false)]
        [Column("PRODUCTNATURE")]
        public virtual string? ProductNature { get; set; }

        [Column("PRODUCTORCURRENCY")]
        public virtual Anu.PunishmentOrg.Enumerations.PProductOrCurrency? ProductOrCurrency { get; set; }

        [Column("PRODUCTPRIMVALUE")]
        public virtual decimal? ProductPrimValue { get; set; }

        [Unicode(false)]
        [Column("PRODUCTSUBSIDIARYGRADE")]
        public virtual string? ProductSubsidiaryGrade { get; set; }

        [Unicode(false)]
        [Column("PRODUCTTITLE")]
        public virtual string? ProductTitle { get; set; }

        [Column("PRODUCTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PProductType? ProductType { get; set; }

        [Column("REMINDVALUE")]
        public virtual decimal? RemindValue { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Unicode(false)]
        [Column("SERIALNUMBER")]
        public virtual string? SerialNumber { get; set; }

        [Unicode(false)]
        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBBILLMEASUREMENTUNITTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBillMeasurementUnitType? ThePBBillMeasurementUnitType { get; set; }

        [ForeignKey("PBBILLPRODUCTGRPID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBillProductGrp? ThePBBillProductGrp { get; set; }

        [ForeignKey("PBILLSTOREID")]
        public virtual Anu.PunishmentOrg.DataModel.BillStore.PBillStore? ThePBillStore { get; set; }

        [InverseProperty("ThePBillStoreProduct")]
        public virtual List<Anu.PunishmentOrg.DataModel.BillStore.PBillStoreProductDiscovery>? ThePBillStoreProductDiscoveryList { get; set; }

        [ForeignKey("PBPRODUCTCURRENCYTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

        [InverseProperty("ThePBillStoreProduct")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseViolationProductBillST>? ThePCaseViolationProductBillSTList { get; set; }

        [Column("VOLUMEINDONKEY")]
        public virtual long? VolumeInDonkey { get; set; }

        [Column("WEIGHTPRODUCT")]
        public virtual decimal? WeightProduct { get; set; }

        [Column("WOODDIAMETER")]
        public virtual long? WoodDiameter { get; set; }

        [Column("WOODTOTALVOLUME")]
        public virtual long? WoodTotalVolume { get; set; }

        }

    [Table("PBILLSTOREPRODUCT")]
    public partial class PBillStoreProduct : PBillStoreProductBase
    {
    }
    }