

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.BillStore
{
    public abstract class PBillStoreProductBase : PunishmentOrgEntity<string>
    {

		[Column("ARTICLE21")]
		public virtual string? Article21 { get; set; }

		[Column("BRANDNAME")]
		public virtual string? BrandName { get; set; }

		[Column("CARAXLE")]
		public virtual string? CarAxle { get; set; }

		[Column("CARBODYNUMBER")]
		public virtual string? CarBodyNumber { get; set; }

		[Column("CARCAPACITY")]
		public virtual string? CarCapacity { get; set; }

		[Column("CARCHASSISNUMBER")]
		public virtual string? CarChassisNumber { get; set; }

		[Column("CARCOLOR")]
		public virtual string? CarColor { get; set; }

		[Column("CARCYLINDER")]
		public virtual string? CarCylinder { get; set; }

		[Column("CARDOORNUMBER")]
		public virtual string? CarDoorNumber { get; set; }

		[Column("CARENGINEVOLUME")]
		public virtual string? CarEngineVolume { get; set; }

		[Column("CARENGINNUMBER")]
		public virtual string? CarEnginNumber { get; set; }

		[Column("CARFUEL")]
		public virtual string? CarFuel { get; set; }

		[Column("CARGEARBOXTYPE")]
		public virtual string? CarGearboxType { get; set; }

		[Column("CARMALFUNCTIONSTATUS")]
		public virtual Anu.Enumerations.YesNo? CarMalfunctionStatus { get; set; }

		[Column("CARMODEL")]
		public virtual string? CarModel { get; set; }

		[Column("CARPLAQUE")]
		public virtual string? CarPlaque { get; set; }

		[Column("CARPLAQUEDATE")]
		public virtual string? CarPlaqueDate { get; set; }

		[Column("CARSTYLE")]
		public virtual string? CarStyle { get; set; }

		[Column("CARSYSTEM")]
		public virtual string? CarSystem { get; set; }

		[Column("CARTYPE")]
		public virtual string? CarType { get; set; }

		[Column("CARUSAGE")]
		public virtual string? CarUsage { get; set; }

		[Column("CARWHEEL")]
		public virtual string? CarWheel { get; set; }

		[Column("COUNTRYCREATE")]
		public virtual string? CountryCreate { get; set; }

		[Column("CURRENCYUNIT")]
		public virtual string? CurrencyUnit { get; set; }

		[Column("CURRENCYVALUE")]
		public virtual long? CurrencyValue { get; set; }

		[Column("DISCOVERYROWNUMBERS")]
		public virtual string? DiscoveryRowNumbers { get; set; }

		[Column("ESTIMATEDVALUE")]
		public virtual decimal? EstimatedValue { get; set; }

		[Column("EXPIREDATE")]
		public virtual string? ExpireDate { get; set; }

		[Column("IDNUMBER")]
		public virtual string? IDNumber { get; set; }

		[Column("ISFIREWOOD")]
		public virtual Anu.Enumerations.YesNo? IsFireWood { get; set; }

		[Column("JEWELRYCOARSE")]
		public virtual string? JewelryCoarse { get; set; }

		[Column("JEWELRYCUT")]
		public virtual string? JewelryCut { get; set; }

		[Column("JEWELRYCUTTING")]
		public virtual string? JewelryCutting { get; set; }

		[Column("JEWELRYMATERIAL")]
		public virtual string? JewelryMaterial { get; set; }

		[Column("JEWELRYWEIGHT")]
		public virtual string? JewelryWeight { get; set; }

		[Column("NONESSENTIALPETROLEUMPRODUCT")]
		public virtual string? NonEssentialPetroleumProduct { get; set; }

		[Column("OBJECTARCHAISM")]
		public virtual long? ObjectArchaism { get; set; }

		[Column("OBJECTCULTURALVALUE")]
		public virtual string? ObjectCulturalValue { get; set; }

		[Column("OBJECTDESC")]
		public virtual string? ObjectDesc { get; set; }

		[Column("OBJECTGENDER")]
		public virtual string? ObjectGender { get; set; }

		[Column("OBJECTHEIGHT")]
		public virtual long? ObjectHeight { get; set; }

		[Column("OBJECTIMAGE")]
		public virtual byte[]? ObjectImage { get; set; }

		[Column("OBJECTLENGTH")]
		public virtual long? ObjectLength { get; set; }

		[Column("OBJECTORIGINALITY")]
		public virtual Anu.Enumerations.PunishmentOrg.ObjectOriginality? ObjectOriginality { get; set; }

		[Column("OBJECTWIDTH")]
		public virtual long? ObjectWidth { get; set; }

		[Column("PACKINGTYPE")]
		public virtual string? PackingType { get; set; }

		[Column("PRIMERYVALUE")]
		public virtual decimal? PrimeryValue { get; set; }

		[Column("PRODUCTDESC")]
		public virtual string? ProductDesc { get; set; }

		[Column("PRODUCTMAINGRADE")]
		public virtual string? ProductMainGrade { get; set; }

		[Column("PRODUCTNATURE")]
		public virtual string? ProductNature { get; set; }

		[Column("PRODUCTORCURRENCY")]
		public virtual Anu.Enumerations.PunishmentOrg.PProductOrCurrency? ProductOrCurrency { get; set; }

		[Column("PRODUCTPRIMVALUE")]
		public virtual decimal? ProductPrimValue { get; set; }

		[Column("PRODUCTSUBSIDIARYGRADE")]
		public virtual string? ProductSubsidiaryGrade { get; set; }

		[Column("PRODUCTTITLE")]
		public virtual string? ProductTitle { get; set; }

		[Column("PRODUCTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PProductType? ProductType { get; set; }

		[Column("REMINDVALUE")]
		public virtual decimal? RemindValue { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SERIALNUMBER")]
		public virtual string? SerialNumber { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBBILLMEASUREMENTUNITTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBillMeasurementUnitType? ThePBBillMeasurementUnitType { get; set; }

		[ForeignKey("PBBILLPRODUCTGRPID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBillProductGrp? ThePBBillProductGrp { get; set; }

		[ForeignKey("PBILLSTOREID")]
		public virtual Anu.PunishmentOrg.BillStore.PBillStore? ThePBillStore { get; set; }

		[InverseProperty("ThePBillStoreProduct")]
		public virtual List<Anu.PunishmentOrg.BillStore.PBillStoreProductDiscovery>? ThePBillStoreProductDiscoveryList { get; set; }

		[ForeignKey("PBPRODUCTCURRENCYTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

		[InverseProperty("ThePBillStoreProduct")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseViolationProductBillST>? ThePCaseViolationProductBillSTList { get; set; }

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
    public partial class PBillStoreProduct : PBillStoreProductBase { }

    }


