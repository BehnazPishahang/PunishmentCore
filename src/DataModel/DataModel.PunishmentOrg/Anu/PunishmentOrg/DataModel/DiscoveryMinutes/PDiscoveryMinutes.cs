﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
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
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryMinutesCompetenceReference? CompetenceReference { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("DISCOVERYDATE")]
        public virtual string? DiscoveryDate { get; set; }

        [Column("DISCOVERYDOCTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryDocType? DiscoveryDocType { get; set; }

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
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryPlacePhoneNum? DiscoveryPlacePhoneNumRN { get; set; }

        [Column("DISCOVERYPLACEPLAQUE")]
        public virtual string? DiscoveryPlacePlaque { get; set; }

        [Column("DISCOVERYPLACEPLAQUERN")]
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryPlacePlaque? DiscoveryPlacePlaqueRN { get; set; }

        [Column("DISCOVERYPLACEPOSTALCODE")]
        public virtual string? DiscoveryPlacePostalCode { get; set; }

        [Column("DISCOVERYPLACEPOSTALCODERN")]
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryPlacePostalCode? DiscoveryPlacePostalCodeRN { get; set; }

        [Column("DISCOVERYPLACEUNITNAME")]
        public virtual string? DiscoveryPlaceUnitName { get; set; }

        [Column("DISCOVERYPLACEUNITNAMERN")]
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryPlaceUnitName? DiscoveryPlaceUnitNameRN { get; set; }

        [Column("DISCOVERYTIME")]
        public virtual string? DiscoveryTime { get; set; }

        [Column("DISCOVERYTYPEOTHERPLACE")]
        public virtual string? DiscoveryTypeOtherPlace { get; set; }

        [Column("ENGHELABCOURTNO")]
        public virtual long? EnghelabCourtNo { get; set; }

        [Column("EVIDENCEPOSSIBILITY")]
        public virtual string? EvidencePossibility { get; set; }

        [Column("HAVEPLACELICENSENUMBER")]
        public virtual Anu.BaseInfo.Enumerations.HaveNoHave? HavePlacelicenseNumber { get; set; }

        [Column("HOWFINDARREST")]
        public virtual string? HowFindArrest { get; set; }

        [Column("INACCESSACCUSEREASON")]
        public virtual string? InaccessAccuseReason { get; set; }

        [Column("INACCESSPRODUCTREASON")]
        public virtual string? InaccessProductReason { get; set; }

        [Column("ISVEHICLE")]
        public virtual Anu.BaseInfo.Enumerations.HaveAttachment? IsVehicle { get; set; }

        [Column("KEEPPLACESTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PURegister? KeepPlaceState { get; set; }

        [Column("LACKOFOWNERSHIPREASON")]
        public virtual string? LackOfOwnershipReason { get; set; }

        [Column("NOTIFYOFAWARE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? NotifyOfAware { get; set; }

        [Column("PRODUCTFOUNDDESC")]
        public virtual string? ProductFoundDesc { get; set; }

        [Column("PRODUCTFOUNDDESCRN")]
        public virtual Anu.PunishmentOrg.Enumerations.ProductFoundDesc? ProductFoundDescRN { get; set; }

        [Column("REASONCHOICEACCORDANCELAW")]
        public virtual Anu.PunishmentOrg.Enumerations.PReasonChoiceCasesAccordanceWithLaw? ReasonChoiceAccordanceLaw { get; set; }

        [Column("REASONCHOICEREFRENCE")]
        public virtual Anu.PunishmentOrg.Enumerations.PReferenceSelectReason? ReasonChoiceRefrence { get; set; }

        [Column("SMUGGLINGTRICK")]
        public virtual string? SmugglingTrick { get; set; }

        [Column("SMUGGLINGTYPEOTHERS")]
        public virtual string? SmugglingTypeOthers { get; set; }

        [Column("SMUGGLINGWITHCRIMES")]
        public virtual string? SmugglingWithCrimes { get; set; }

        [Column("SUSPECTSTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.SuspectState? SuspectState { get; set; }

        [ForeignKey("CITYPUOREFUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheCityPuoRefUnit { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.BillStore.PBillStore>? ThePBillStoreList { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesAttach>? ThePDiscoveryMinutesAttachList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesDcType>? ThePDiscoveryMinutesDcTypeList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesDocFound>? ThePDiscoveryMinutesDocFoundList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesOfficer>? ThePDiscoveryMinutesOfficerList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesProductFound>? ThePDiscoveryMinutesProductFoundList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesSmugType>? ThePDiscoveryMinutesSmugTypeList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesSuspect>? ThePDiscoveryMinutesSuspectList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesType>? ThePDiscoveryMinutesTypeList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesUnit>? ThePDiscoveryMinutesUnitList { get; set; }

        [InverseProperty("ThePDiscoveryMinutes")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutesVehicle>? ThePDiscoveryMinutesVehicleList { get; set; }

        [ForeignKey("RECEIVERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReceiverUnit { get; set; }

        [ForeignKey("REFERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReferUnit { get; set; }

        [Column("TOTALARTIFACTSVALUE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? TotalArtifactsValue { get; set; }

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
    public partial class PDiscoveryMinutes : PDiscoveryMinutesBase
    {
    }
}