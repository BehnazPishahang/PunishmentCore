

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("DIRECTORADDRESS")]
        public virtual string? DirectorAddress { get; set; }

        [Column("DIRECTORBIRTHDATE")]
        public virtual string? DirectorBirthDate { get; set; }

        [Column("DIRECTORFAMILY")]
        public virtual string? DirectorFamily { get; set; }

        [Column("DIRECTORFATHERNAME")]
        public virtual string? DirectorFatherName { get; set; }

        [Column("DIRECTORIDENTITYNUMBER")]
        public virtual string? DirectorIdentityNumber { get; set; }

        [Column("DIRECTORMOBILNUMBER")]
        public virtual string? DirectorMobilNumber { get; set; }

        [Column("DIRECTORNAME")]
        public virtual string? DirectorName { get; set; }

        [Column("DIRECTORNATIONALCODE")]
        public virtual string? DirectorNationalCode { get; set; }

        [Column("DIRECTORNATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? DirectorNationality { get; set; }

        [Column("DIRECTORNONIRANIANCNT")]
        public virtual string? DirectorNonIranianCnt { get; set; }

        [Column("DIRECTORPASSPORTNO")]
        public virtual string? DirectorPassportNo { get; set; }

        [Column("DIRECTORPOSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PSuspectPostType? DirectorPostType { get; set; }

        [Column("DIRECTORSEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? DirectorSex { get; set; }

        [Column("ECONOMICCODE")]
        public virtual string? EconomicCode { get; set; }

        [Column("GOVORGOWNER")]
        public virtual string? GovOrgOwner { get; set; }

        [Column("GRAVAMENDATE")]
        public virtual string? GravamenDate { get; set; }

        [Column("GRAVAMENNO")]
        public virtual string? GravamenNo { get; set; }

        [Column("HASVIOLATION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? HasViolation { get; set; }

        [Column("HOWDATATYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.HowGetDataInspectionReport? HowDataType { get; set; }

        [Column("INSPECTIONDATETIME")]
        public virtual string? InspectionDateTime { get; set; }

        [Column("INSPECTIONREPORTNO")]
        public virtual string? InspectionReportNo { get; set; }

        [Column("INSPECTIONREPORTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.InspectionReportType? InspectionReportType { get; set; }

        [Column("INSPECTIONRPTCOMPLETEDATE")]
        public virtual string? InspectionRptCompleteDate { get; set; }

        [Column("KEEPPLACESTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PURegister? KeepPlaceState { get; set; }

        [Column("LICENSEOWNERADDRESS")]
        public virtual string? LicenseOwnerAddress { get; set; }

        [Column("LICENSEOWNERBIRTHDATE")]
        public virtual string? LicenseOwnerBirthDate { get; set; }

        [Column("LICENSEOWNERFAMILY")]
        public virtual string? LicenseOwnerFamily { get; set; }

        [Column("LICENSEOWNERFATHERNAME")]
        public virtual string? LicenseOwnerFatherName { get; set; }

        [Column("LICENSEOWNERIDENTITYNUMBER")]
        public virtual string? LicenseOwnerIdentityNumber { get; set; }

        [Column("LICENSEOWNERMOBILNUMBER")]
        public virtual string? LicenseOwnerMobilNumber { get; set; }

        [Column("LICENSEOWNERNAME")]
        public virtual string? LicenseOwnerName { get; set; }

        [Column("LICENSEOWNERNATIONALCODE")]
        public virtual string? LicenseOwnerNationalCode { get; set; }

        [Column("LICENSEOWNERNATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? LicenseOwnerNationality { get; set; }

        [Column("LICENSEOWNERNONIRANIACNT")]
        public virtual string? LicenseOwnerNonIraniaCnt { get; set; }

        [Column("LICENSEOWNERPASSPORTNO")]
        public virtual string? LicenseOwnerPassportNo { get; set; }

        [Column("LICENSEOWNERPOSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PSuspectPostType? LicenseOwnerPostType { get; set; }

        [Column("LICENSEOWNERRESPONSIBILITY")]
        public virtual string? LicenseOwnerResponsibility { get; set; }

        [Column("LICENSEOWNERSEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? LicenseOwnerSex { get; set; }

        [Column("LICENSETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULicenseType? LicenseType { get; set; }

        [Column("LICENSINGNAME")]
        public virtual string? LicensingName { get; set; }

        [Column("MONITORINGPLANTITLE")]
        public virtual string? MonitoringPlanTitle { get; set; }

        [Column("NO")]
        []
        public virtual string? No { get; set; }

        [Column("OWNERESTATETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnerEstateType? OwnerEstateType { get; set; }

        [Column("OWNERSHIPTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUOwnershipType? OwnershipType { get; set; }

        [Column("PLAQUE")]
        public virtual string? Plaque { get; set; }

        [Column("REGDATE")]
        public virtual string? RegDate { get; set; }

        [Column("REGION")]
        public virtual string? Region { get; set; }

        [Column("REGNUMBER")]
        public virtual string? RegNumber { get; set; }

        [Column("REPORTBASE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUInspectionReportBase? ReportBase { get; set; }

        [Column("REPORTBASEOTHER")]
        public virtual string? ReportBaseOther { get; set; }

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
        public virtual Anu.PunishmentOrg.Enumerations.LicenseType? TradeLicense { get; set; }

        [Column("TRADELICENSEDATE")]
        public virtual string? TradeLicenseDate { get; set; }

        [Column("TRADELICENSENUMBER")]
        public virtual string? TradeLicenseNumber { get; set; }

        [Column("TRADEUNITADDRESS")]
        public virtual string? TradeUnitAddress { get; set; }

        [Column("TRADEUNITIDENTITYNUMBER")]
        public virtual string? TradeUnitIdentityNumber { get; set; }

        [Column("TRADEUNITNAME")]
        public virtual string? TradeUnitName { get; set; }

        [Column("TRADEUNITPOSTCODE")]
        public virtual string? TradeUnitPostCode { get; set; }

        [Column("TRADEUNITTELNO")]
        public virtual string? TradeUnitTelNo { get; set; }

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