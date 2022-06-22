

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.InspectionReport
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
		public virtual DataModel.BaseInfo.Anu.Enumerations.LNationality? DirectorNationality { get; set; }

		[Column("DIRECTORNONIRANIANCNT")]
		public virtual string? DirectorNonIranianCnt { get; set; }

		[Column("DIRECTORPASSPORTNO")]
		public virtual string? DirectorPassportNo { get; set; }

		[Column("DIRECTORPOSTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PSuspectPostType? DirectorPostType { get; set; }

		[Column("DIRECTORSEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? DirectorSex { get; set; }

		[Column("ECONOMICCODE")]
		public virtual string? EconomicCode { get; set; }

		[Column("GOVORGOWNER")]
		public virtual string? GovOrgOwner { get; set; }

		[Column("GRAVAMENDATE")]
		public virtual string? GravamenDate { get; set; }

		[Column("GRAVAMENNO")]
		public virtual string? GravamenNo { get; set; }

		[Column("HASVIOLATION")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? HasViolation { get; set; }

		[Column("HOWDATATYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.HowGetDataInspectionReport? HowDataType { get; set; }

		[Column("INSPECTIONDATETIME")]
		public virtual string? InspectionDateTime { get; set; }

		[Column("INSPECTIONREPORTNO")]
		public virtual string? InspectionReportNo { get; set; }

		[Column("INSPECTIONREPORTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.InspectionReportType? InspectionReportType { get; set; }

		[Column("INSPECTIONRPTCOMPLETEDATE")]
		public virtual string? InspectionRptCompleteDate { get; set; }

		[Column("KEEPPLACESTATE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PURegister? KeepPlaceState { get; set; }

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
		public virtual DataModel.BaseInfo.Anu.Enumerations.LNationality? LicenseOwnerNationality { get; set; }

		[Column("LICENSEOWNERNONIRANIACNT")]
		public virtual string? LicenseOwnerNonIraniaCnt { get; set; }

		[Column("LICENSEOWNERPASSPORTNO")]
		public virtual string? LicenseOwnerPassportNo { get; set; }

		[Column("LICENSEOWNERPOSTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PSuspectPostType? LicenseOwnerPostType { get; set; }

		[Column("LICENSEOWNERRESPONSIBILITY")]
		public virtual string? LicenseOwnerResponsibility { get; set; }

		[Column("LICENSEOWNERSEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? LicenseOwnerSex { get; set; }

		[Column("LICENSETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PULicenseType? LicenseType { get; set; }

		[Column("LICENSINGNAME")]
		public virtual string? LicensingName { get; set; }

		[Column("MONITORINGPLANTITLE")]
		public virtual string? MonitoringPlanTitle { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("OWNERESTATETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.OwnerEstateType? OwnerEstateType { get; set; }

		[Column("OWNERSHIPTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUOwnershipType? OwnershipType { get; set; }

		[Column("PLAQUE")]
		public virtual string? Plaque { get; set; }

		[Column("REGDATE")]
		public virtual string? RegDate { get; set; }

		[Column("REGION")]
		public virtual string? Region { get; set; }

		[Column("REGNUMBER")]
		public virtual string? RegNumber { get; set; }

		[Column("REPORTBASE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUInspectionReportBase? ReportBase { get; set; }

		[Column("REPORTBASEOTHER")]
		public virtual string? ReportBaseOther { get; set; }

		[Column("RETURNREASONDESC")]
		public virtual string? ReturnReasonDesc { get; set; }

		[Column("SAVETYPE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? SaveType { get; set; }

		[Column("SUBNO")]
		public virtual long? SubNo { get; set; }

		[ForeignKey("CITYPUOREFUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheCityPuoRefUnit { get; set; }

		[ForeignKey("INSPECTIONUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? TheInspectionUnit { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PBTRADEUNIONSID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBTradeUnions? ThePBTradeUnions { get; set; }

		[ForeignKey("PBTRADEUNITTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBTradeUnitType? ThePBTradeUnitType { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePInspectionReport")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReportAttachment>? ThePInspectionReportAttachmentList { get; set; }

		[InverseProperty("ThePInspectionReport")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReportDirectors>? ThePInspectionReportDirectorsList { get; set; }

		[InverseProperty("ThePInspectionReport")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReportInspector>? ThePInspectionReportInspectorList { get; set; }

		[InverseProperty("ThePInspectionReport")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReportPerson>? ThePInspectionReportPersonList { get; set; }

		[InverseProperty("ThePInspectionReport")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReportRetReason>? ThePInspectionReportRetReasonList { get; set; }

		[InverseProperty("ThePInspectionReport")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PinspectionReportTrade>? ThePinspectionReportTradeList { get; set; }

		[InverseProperty("ThePInspectionReport")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReportViolation>? ThePInspectionReportViolationList { get; set; }

		[ForeignKey("RECEIVEUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheReceiveUnit { get; set; }

		[ForeignKey("REFERUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheReferUnit { get; set; }

		[ForeignKey("REGIONGEOLOCID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.GeoInfo.GeoLocation? TheRegionGeoLoc { get; set; }

		[Column("TOTALDAMAGES")]
		public virtual long? TotalDamages { get; set; }

		[Column("TOTALVIOLATIONPRICE")]
		public virtual long? TotalViolationPrice { get; set; }

		[Column("TRADELICENSE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.LicenseType? TradeLicense { get; set; }

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
    public partial class PInspectionReport : PInspectionReportBase { }

    }


