

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqBase : PunishmentOrgEntity<string>
    {

		[Column("CHASELICENSEREQUESTTEXT")]
		public virtual string? ChaseLicenseRequestText { get; set; }

		[Column("CHASERESULT")]
		public virtual Anu.Enumerations.PunishmentOrg.PChaseResult? ChaseResult { get; set; }

		[Column("CHASETITLE")]
		public virtual string? ChaseTitle { get; set; }

		[Column("CONCLUSIONREQUEST")]
		public virtual Anu.Enumerations.PunishmentOrg.PUConclusion? ConclusionRequest { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CRIMESANDVIOLATIONSSEEN")]
		public virtual string? CrimesANDViolationsSeen { get; set; }

		[Column("INSTITUTIONCODE")]
		public virtual string? InstitutionCode { get; set; }

		[Column("INSTITUTIONEXPORTER")]
		public virtual Anu.Enumerations.PunishmentOrg.DiscoveryMinutesCompetenceReference? InstitutionExporter { get; set; }

		[Column("INSTITUTIONTITLE")]
		public virtual string? InstitutionTitle { get; set; }

		[Column("LETTERREQUESTDATETIME")]
		public virtual string? LetterRequestDateTime { get; set; }

		[Column("LETTERREQUESTNO")]
		public virtual string? LetterRequestNo { get; set; }

		[Column("LICENSORREQUESTTEXT")]
		public virtual string? LicensorRequestText { get; set; }

		[Column("LICENSORVALIDITYDAYS")]
		public virtual long? LicensorValidityDays { get; set; }

		[Column("NONDISCOVERYREPTEXT")]
		public virtual string? NonDiscoveryRepText { get; set; }

		[Column("RECEIVEDATETIME")]
		public virtual string? ReceiveDateTime { get; set; }

		[Column("REPSENDDATETIME")]
		public virtual string? RepSendDateTime { get; set; }

		[Column("REPTEXT")]
		public virtual string? RepText { get; set; }

		[Column("REQDATE")]
		public virtual string? ReqDate { get; set; }

		[Column("REQTIME")]
		public virtual string? ReqTime { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SUBNO")]
		public virtual long? SubNo { get; set; }

		[ForeignKey("CITYPUOREFUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheCityPuoRefUnit { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("JUDICIALUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? TheJudicialUnit { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqCrim>? ThePChaseLicenseReqCrimList { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqDoc>? ThePChaseLicenseReqDocList { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqPlaces>? ThePChaseLicenseReqPlacesList { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqSuspect>? ThePChaseLicenseReqSuspectList { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqType>? ThePChaseLicenseReqTypeList { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqUnit>? ThePChaseLicenseReqUnitList { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReqVehicle>? ThePChaseLicenseReqVehicleList { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>? ThePDiscoveryMinutesList { get; set; }

		[InverseProperty("ThePChaseLicenseReq")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PReportViolation>? ThePReportViolationList { get; set; }

		[ForeignKey("PRVREQID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReq? ThePrvReq { get; set; }

		[ForeignKey("REFERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheReferUnit { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("UNIQUENO")]
		public virtual string? UniqueNo { get; set; }

		[Column("UNWRITEREQDESCBYLICENSOR")]
		public virtual string? UnwriteReqDescByLicensor { get; set; }

		[Column("UNWRITEREQDESCBYOFFICER")]
		public virtual string? UnwriteReqDescByOfficer { get; set; }

		[Column("UNWRITEREQRESULTBYLICENSOR")]
		public virtual Anu.Enumerations.PunishmentOrg.PUConclusion? UnwriteReqResultByLicensor { get; set; }

		[Column("UNWRITEREQRESULTBYOFFICER")]
		public virtual Anu.Enumerations.PunishmentOrg.PUConclusion? UnwriteReqResultByOfficer { get; set; }

		[Column("UNWRITTENREQFAMILY")]
		public virtual string? UnwrittenReqFamily { get; set; }

		[Column("UNWRITTENREQNAME")]
		public virtual string? UnwrittenReqName { get; set; }

		[Column("VALIDITYDAYS")]
		public virtual long? ValidityDays { get; set; }

		[Column("WRITTENORORAL")]
		public virtual Anu.Enumerations.PunishmentOrg.WrittenOrOral? WrittenOrOral { get; set; }

    }
    [Table("PCHASELICENSEREQ")]
    public partial class PChaseLicenseReq : PChaseLicenseReqBase { }

    }


