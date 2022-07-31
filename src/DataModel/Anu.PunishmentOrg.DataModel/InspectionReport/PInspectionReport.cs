

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DIRECTORADDRESS")]
        public virtual string? DirectorAddress { get; set; }

        [Unicode(false)]
        [Column("DIRECTORBIRTHDATE")]
        public virtual string? DirectorBirthDate { get; set; }

        [Unicode(false)]
        [Column("DIRECTORFAMILY")]
        public virtual string? DirectorFamily { get; set; }

        [Unicode(false)]
        [Column("DIRECTORFATHERNAME")]
        public virtual string? DirectorFatherName { get; set; }

        [Unicode(false)]
        [Column("DIRECTORIDENTITYNUMBER")]
        public virtual string? DirectorIdentityNumber { get; set; }

        [Unicode(false)]
        [Column("DIRECTORMOBILNUMBER")]
        public virtual string? DirectorMobilNumber { get; set; }

        [Unicode(false)]
        [Column("DIRECTORNAME")]
        public virtual string? DirectorName { get; set; }

        [Unicode(false)]
        [Column("DIRECTORNATIONALCODE")]
        public virtual string? DirectorNationalCode { get; set; }

        [Column("DIRECTORNATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? DirectorNationality { get; set; }

        [Unicode(false)]
        [Column("DIRECTORNONIRANIANCNT")]
        public virtual string? DirectorNonIranianCnt { get; set; }

        [Unicode(false)]
        [Column("DIRECTORPASSPORTNO")]
        public virtual string? DirectorPassportNo { get; set; }

        [Column("DIRECTORPOSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PSuspectPostType? DirectorPostType { get; set; }

        [Column("DIRECTORSEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? DirectorSex { get; set; }

        [Unicode(false)]
        [Column("ECONOMICCODE")]
        public virtual string? EconomicCode { get; set; }

        [Unicode(false)]
        [Column("GOVORGOWNER")]
        public virtual string? GovOrgOwner { get; set; }

        [Unicode(false)]
        [Column("GRAVAMENDATE")]
        public virtual string? GravamenDate { get; set; }

        [Unicode(false)]
        [Column("GRAVAMENNO")]
        public virtual string? GravamenNo { get; set; }

        [Column("HASVIOLATION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? HasViolation { get; set; }

        [Column("HOWDATATYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.HowGetDataInspectionReport? HowDataType { get; set; }

        [Unicode(false)]
        [Column("INSPECTIONDATETIME")]
        public virtual string? InspectionDateTime { get; set; }

        [Unicode(false)]
        [Column("INSPECTIONREPORTNO")]
        public virtual string? InspectionReportNo { get; set; }

        [Column("INSPECTIONREPORTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.InspectionReportType? InspectionReportType { get; set; }

        [Unicode(false)]
        [Column("INSPECTIONRPTCOMPLETEDATE")]
        public virtual string? InspectionRptCompleteDate { get; set; }

        [Column("KEEPPLACESTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PURegister? KeepPlaceState { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERADDRESS")]
        public virtual string? LicenseOwnerAddress { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERBIRTHDATE")]
        public virtual string? LicenseOwnerBirthDate { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERFAMILY")]
        public virtual string? LicenseOwnerFamily { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERFATHERNAME")]
        public virtual string? LicenseOwnerFatherName { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERIDENTITYNUMBER")]
        public virtual string? LicenseOwnerIdentityNumber { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERMOBILNUMBER")]
        public virtual string? LicenseOwnerMobilNumber { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERNAME")]
        public virtual string? LicenseOwnerName { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERNATIONALCODE")]
        public virtual string? LicenseOwnerNationalCode { get; set; }

        [Column("LICENSEOWNERNATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? LicenseOwnerNationality { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERNONIRANIACNT")]
        public virtual string? LicenseOwnerNonIraniaCnt { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERPASSPORTNO")]
        public virtual string? LicenseOwnerPassportNo { get; set; }

        [Column("LICENSEOWNERPOSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PSuspectPostType? LicenseOwnerPostType { get; set; }

        [Unicode(false)]
        [Column("LICENSEOWNERRESPONSIBILITY")]
        public virtual string? LicenseOwnerResponsibility { get; set; }

        [Column("LICENSEOWNERSEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? LicenseOwnerSex { get; set; }

        [Column("LICENSETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULicenseType? LicenseType { get; set; }

        [Unicode(false)]
        [Column("LICENSINGNAME")]
        public virtual string? LicensingName { get; set; }

        [Unicode(false)]
        [Column("MONITORINGPLANTITLE")]
        public virtual string? MonitoringPlanTitle { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("OWNERESTATETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnerEstateType? OwnerEstateType { get; set; }

        [Column("OWNERSHIPTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUOwnershipType? OwnershipType { get; set; }

        [Unicode(false)]
        [Column("PLAQUE")]
        public virtual string? Plaque { get; set; }

        [Unicode(false)]
        [Column("REGDATE")]
        public virtual string? RegDate { get; set; }

        [Unicode(false)]
        [Column("REGION")]
        public virtual string? Region { get; set; }

        [Unicode(false)]
        [Column("REGNUMBER")]
        public virtual string? RegNumber { get; set; }

        [Column("REPORTBASE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUInspectionReportBase? ReportBase { get; set; }

        [Unicode(false)]
        [Column("REPORTBASEOTHER")]
        public virtual string? ReportBaseOther { get; set; }

        [Unicode(false)]
        [Column("RETURNREASONDESC")]
        public virtual string? ReturnReasonDesc { get; set; }

        [Column("SAVETYPE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SaveType { get; set; }

        [Column("SUBNO")]
        public virtual long? SubNo { get; set; }

        [ForeignKey("CITYPUOREFUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheCityPuoRefUnit { get; set; }

        [ForeignKey("INSPECTIONUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? TheInspectionUnit { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBTRADEUNIONSID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTradeUnions? ThePBTradeUnions { get; set; }

        [ForeignKey("PBTRADEUNITTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTradeUnitType? ThePBTradeUnitType { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePInspectionReport")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportAttachment>? ThePInspectionReportAttachmentList { get; set; }

        [InverseProperty("ThePInspectionReport")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportDirectors>? ThePInspectionReportDirectorsList { get; set; }

        [InverseProperty("ThePInspectionReport")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportInspector>? ThePInspectionReportInspectorList { get; set; }

        [InverseProperty("ThePInspectionReport")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportPerson>? ThePInspectionReportPersonList { get; set; }

        [InverseProperty("ThePInspectionReport")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportRetReason>? ThePInspectionReportRetReasonList { get; set; }

        [InverseProperty("ThePInspectionReport")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PinspectionReportTrade>? ThePinspectionReportTradeList { get; set; }

        [InverseProperty("ThePInspectionReport")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportViolation>? ThePInspectionReportViolationList { get; set; }

        [ForeignKey("RECEIVEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReceiveUnit { get; set; }

        [ForeignKey("REFERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReferUnit { get; set; }

        [ForeignKey("REGIONGEOLOCID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheRegionGeoLoc { get; set; }

        [Column("TOTALDAMAGES")]
        public virtual long? TotalDamages { get; set; }

        [Column("TOTALVIOLATIONPRICE")]
        public virtual long? TotalViolationPrice { get; set; }

        [Column("TRADELICENSE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULicenseType? TradeLicense { get; set; }

        [Unicode(false)]
        [Column("TRADELICENSEDATE")]
        public virtual string? TradeLicenseDate { get; set; }

        [Unicode(false)]
        [Column("TRADELICENSENUMBER")]
        public virtual string? TradeLicenseNumber { get; set; }

        [Unicode(false)]
        [Column("TRADEUNITADDRESS")]
        public virtual string? TradeUnitAddress { get; set; }

        [Unicode(false)]
        [Column("TRADEUNITIDENTITYNUMBER")]
        public virtual string? TradeUnitIdentityNumber { get; set; }

        [Unicode(false)]
        [Column("TRADEUNITNAME")]
        public virtual string? TradeUnitName { get; set; }

        [Unicode(false)]
        [Column("TRADEUNITPOSTCODE")]
        public virtual string? TradeUnitPostCode { get; set; }

        [Unicode(false)]
        [Column("TRADEUNITTELNO")]
        public virtual string? TradeUnitTelNo { get; set; }

        [Unicode(false)]
        [Column("TRADEUNITTYPEOTHER")]
        public virtual string? TradeUnitTypeOther { get; set; }

        [Column("VIOLATIONCOUNT")]
        public virtual long? ViolationCount { get; set; }

    }

    [Table("PINSPECTIONREPORT")]
    public partial class PInspectionReport : PInspectionReportBase
    {
    }
    }