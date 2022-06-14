

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesBase : PunishmentOrgEntity<string>
    {

		[Column("ARTICLE21NOTICEDATE")]
		public virtual string? Article21NoticeDate { get; set; }

		[Column("BILLNOPRODUCTORDOCFOUND")]
		public virtual string? BillNoProductOrDocFound { get; set; }

		[Column("CASENO")]
		public virtual string? CaseNo { get; set; }

		[Column("CASESUBNO")]
		public virtual long? CaseSubNo { get; set; }

		[Column("COMPETENCEREFERENCE")]
		public virtual Anu.Enumerations.PunishmentOrg.DiscoveryMinutesCompetenceReference? CompetenceReference { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DISCOVERYDATE")]
		public virtual string? DiscoveryDate { get; set; }

		[Column("DISCOVERYDOCTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.DiscoveryDocType? DiscoveryDocType { get; set; }

		[Column("DISCOVERYNO")]
		public virtual string? DiscoveryNO { get; set; }

		[Column("DISCOVERYOFFICERUNIT")]
		public virtual string? DiscoveryOfficerUnit { get; set; }

		[Column("DISCOVERYPLACEADDRESS")]
		public virtual string? DiscoveryPlaceAddress { get; set; }

		[Column("DISCOVERYPLACEBENEFICIARY")]
		public virtual string? DiscoveryPlaceBeneficiary { get; set; }

		[Column("DISCOVERYPLACEBENEFICIARYRN")]
		public virtual string? DiscoveryPlaceBeneficiaryRN { get; set; }

		[Column("DISCOVERYPLACELICENSENUMBER")]
		public virtual string? DiscoveryPlacelicenseNumber { get; set; }

		[Column("DISCOVERYPLACEOWNER")]
		public virtual string? DiscoveryPlaceOwner { get; set; }

		[Column("DISCOVERYPLACEOWNERRN")]
		public virtual string? DiscoveryPlaceOwnerRN { get; set; }

		[Column("DISCOVERYPLACEPHONENUM")]
		public virtual string? DiscoveryPlacePhoneNum { get; set; }

		[Column("DISCOVERYPLACEPHONENUMRN")]
		public virtual Anu.Enumerations.PunishmentOrg.DiscoveryPlacePhoneNum? DiscoveryPlacePhoneNumRN { get; set; }

		[Column("DISCOVERYPLACEPLAQUE")]
		public virtual string? DiscoveryPlacePlaque { get; set; }

		[Column("DISCOVERYPLACEPLAQUERN")]
		public virtual Anu.Enumerations.PunishmentOrg.DiscoveryPlacePlaque? DiscoveryPlacePlaqueRN { get; set; }

		[Column("DISCOVERYPLACEPOSTALCODE")]
		public virtual string? DiscoveryPlacePostalCode { get; set; }

		[Column("DISCOVERYPLACEPOSTALCODERN")]
		public virtual Anu.Enumerations.PunishmentOrg.DiscoveryPlacePostalCode? DiscoveryPlacePostalCodeRN { get; set; }

		[Column("DISCOVERYPLACEUNITNAME")]
		public virtual string? DiscoveryPlaceUnitName { get; set; }

		[Column("DISCOVERYPLACEUNITNAMERN")]
		public virtual Anu.Enumerations.PunishmentOrg.DiscoveryPlaceUnitName? DiscoveryPlaceUnitNameRN { get; set; }

		[Column("DISCOVERYTIME")]
		public virtual string? DiscoveryTime { get; set; }

		[Column("DISCOVERYTYPEOTHERPLACE")]
		public virtual string? DiscoveryTypeOtherPlace { get; set; }

		[Column("ENGHELABCOURTNO")]
		public virtual long? EnghelabCourtNo { get; set; }

		[Column("EVIDENCEPOSSIBILITY")]
		public virtual string? EvidencePossibility { get; set; }

		[Column("HAVEPLACELICENSENUMBER")]
		public virtual Anu.Enumerations.HaveNoHave? HavePlacelicenseNumber { get; set; }

		[Column("HOWFINDARREST")]
		public virtual string? HowFindArrest { get; set; }

		[Column("INACCESSACCUSEREASON")]
		public virtual string? InaccessAccuseReason { get; set; }

		[Column("INACCESSPRODUCTREASON")]
		public virtual string? InaccessProductReason { get; set; }

		[Column("ISVEHICLE")]
		public virtual Anu.Enumerations.HaveAttachment? IsVehicle { get; set; }

		[Column("KEEPPLACESTATE")]
		public virtual Anu.Enumerations.PunishmentOrg.PURegister? KeepPlaceState { get; set; }

		[Column("LACKOFOWNERSHIPREASON")]
		public virtual string? LackOfOwnershipReason { get; set; }

		[Column("NOTIFYOFAWARE")]
		public virtual Anu.Enumerations.YesNo? NotifyOfAware { get; set; }

		[Column("PRODUCTFOUNDDESC")]
		public virtual string? ProductFoundDesc { get; set; }

		[Column("PRODUCTFOUNDDESCRN")]
		public virtual Anu.Enumerations.PunishmentOrg.ProductFoundDesc? ProductFoundDescRN { get; set; }

		[Column("REASONCHOICEACCORDANCELAW")]
		public virtual Anu.Enumerations.PunishmentOrg.PReasonChoiceCasesAccordanceWithLaw? ReasonChoiceAccordanceLaw { get; set; }

		[Column("REASONCHOICEREFRENCE")]
		public virtual Anu.Enumerations.PunishmentOrg.PReferenceSelectReason? ReasonChoiceRefrence { get; set; }

		[Column("SMUGGLINGTRICK")]
		public virtual string? SmugglingTrick { get; set; }

		[Column("SMUGGLINGTYPEOTHERS")]
		public virtual string? SmugglingTypeOthers { get; set; }

		[Column("SMUGGLINGWITHCRIMES")]
		public virtual string? SmugglingWithCrimes { get; set; }

		[Column("SUSPECTSTATE")]
		public virtual Anu.Enumerations.PunishmentOrg.SuspectState? SuspectState { get; set; }

		[ForeignKey("CITYPUOREFUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheCityPuoRefUnit { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.BillStore.PBillStore>? ThePBillStoreList { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PCHASELICENSEREQID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesAttach>? ThePDiscoveryMinutesAttachList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesDcType>? ThePDiscoveryMinutesDcTypeList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesDocFound>? ThePDiscoveryMinutesDocFoundList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesOfficer>? ThePDiscoveryMinutesOfficerList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesProductFound>? ThePDiscoveryMinutesProductFoundList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesSmugType>? ThePDiscoveryMinutesSmugTypeList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesSuspect>? ThePDiscoveryMinutesSuspectList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesType>? ThePDiscoveryMinutesTypeList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesUnit>? ThePDiscoveryMinutesUnitList { get; set; }

		[InverseProperty("ThePDiscoveryMinutes")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesVehicle>? ThePDiscoveryMinutesVehicleList { get; set; }

		[ForeignKey("RECEIVERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheReceiverUnit { get; set; }

		[ForeignKey("REFERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheReferUnit { get; set; }

		[Column("TOTALARTIFACTSVALUE")]
		public virtual Anu.Enumerations.YesNo? TotalArtifactsValue { get; set; }

		[Column("TOTALPRODUCTFOUND")]
		public virtual decimal? TotalProductFound { get; set; }

		[Column("TRACKINGCODESTORES")]
		public virtual string? TrackingCodeStores { get; set; }

		[Column("UNIQUENO")]
		public virtual string? UniqueNo { get; set; }

		[Column("VERIFICATIONDATETIME")]
		public virtual string? VerificationDateTime { get; set; }

		[Column("VERIFICATIONRESULT")]
		public virtual string? VerificationResult { get; set; }

		[Column("ZONENAME")]
		public virtual string? ZoneName { get; set; }

    }
    [Table("PDISCOVERYMINUTES")]
    public partial class PDiscoveryMinutes : PDiscoveryMinutesBase { }

    }


