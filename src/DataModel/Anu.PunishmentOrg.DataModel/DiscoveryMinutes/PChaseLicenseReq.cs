

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CHASELICENSEREQUESTTEXT")]
        public virtual string? ChaseLicenseRequestText { get; set; }

        [Column("CHASERESULT")]
        public virtual Anu.PunishmentOrg.Enumerations.PChaseResult? ChaseResult { get; set; }

        [Unicode(false)]
        [Column("CHASETITLE")]
        public virtual string? ChaseTitle { get; set; }

        [Column("CONCLUSIONREQUEST")]
        public virtual Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("CRIMESANDVIOLATIONSSEEN")]
        public virtual string? CrimesANDViolationsSeen { get; set; }

        [Unicode(false)]
        [Column("INSTITUTIONCODE")]
        public virtual string? InstitutionCode { get; set; }

        [Column("INSTITUTIONEXPORTER")]
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryMinutesCompetenceReference? InstitutionExporter { get; set; }

        [Unicode(false)]
        [Column("INSTITUTIONTITLE")]
        public virtual string? InstitutionTitle { get; set; }

        [Unicode(false)]
        [Column("LETTERREQUESTDATETIME")]
        public virtual string? LetterRequestDateTime { get; set; }

        [Unicode(false)]
        [Column("LETTERREQUESTNO")]
        public virtual string? LetterRequestNo { get; set; }

        [Unicode(false)]
        [Column("LICENSORREQUESTTEXT")]
        public virtual string? LicensorRequestText { get; set; }

        [Column("LICENSORVALIDITYDAYS")]
        public virtual long? LicensorValidityDays { get; set; }

        [Unicode(false)]
        [Column("NONDISCOVERYREPTEXT")]
        public virtual string? NonDiscoveryRepText { get; set; }

        [Unicode(false)]
        [Column("RECEIVEDATETIME")]
        public virtual string? ReceiveDateTime { get; set; }

        [Unicode(false)]
        [Column("REPSENDDATETIME")]
        public virtual string? RepSendDateTime { get; set; }

        [Unicode(false)]
        [Column("REPTEXT")]
        public virtual string? RepText { get; set; }

        [Unicode(false)]
        [Column("REQDATE")]
        public virtual string? ReqDate { get; set; }

        [Unicode(false)]
        [Column("REQTIME")]
        public virtual string? ReqTime { get; set; }

        [Unicode(false)]
        [Column("SENDDATETIME")]
        public virtual string? SendDateTime { get; set; }

        [Column("SUBNO")]
        public virtual long? SubNo { get; set; }

        [ForeignKey("CITYPUOREFUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheCityPuoRefUnit { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("JUDICIALUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? TheJudicialUnit { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqCrim>? ThePChaseLicenseReqCrimList { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqDoc>? ThePChaseLicenseReqDocList { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqPlaces>? ThePChaseLicenseReqPlacesList { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqSuspect>? ThePChaseLicenseReqSuspectList { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqType>? ThePChaseLicenseReqTypeList { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqUnit>? ThePChaseLicenseReqUnitList { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReqVehicle>? ThePChaseLicenseReqVehicleList { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes>? ThePDiscoveryMinutesList { get; set; }

        [InverseProperty("ThePChaseLicenseReq")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolation>? ThePReportViolationList { get; set; }

        [ForeignKey("PRVREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePrvReq { get; set; }

        [ForeignKey("REFERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReferUnit { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Unicode(false)]
        [Column("UNIQUENO")]
        public virtual string? UniqueNo { get; set; }

        [Unicode(false)]
        [Column("UNWRITEREQDESCBYLICENSOR")]
        public virtual string? UnwriteReqDescByLicensor { get; set; }

        [Unicode(false)]
        [Column("UNWRITEREQDESCBYOFFICER")]
        public virtual string? UnwriteReqDescByOfficer { get; set; }

        [Column("UNWRITEREQRESULTBYLICENSOR")]
        public virtual Anu.PunishmentOrg.Enumerations.PUConclusion? UnwriteReqResultByLicensor { get; set; }

        [Column("UNWRITEREQRESULTBYOFFICER")]
        public virtual Anu.PunishmentOrg.Enumerations.PUConclusion? UnwriteReqResultByOfficer { get; set; }

        [Unicode(false)]
        [Column("UNWRITTENREQFAMILY")]
        public virtual string? UnwrittenReqFamily { get; set; }

        [Unicode(false)]
        [Column("UNWRITTENREQNAME")]
        public virtual string? UnwrittenReqName { get; set; }

        [Column("VALIDITYDAYS")]
        public virtual long? ValidityDays { get; set; }

        [Column("WRITTENORORAL")]
        public virtual Anu.PunishmentOrg.Enumerations.WrittenOrOral? WrittenOrOral { get; set; }

    }

    [Table("PCHASELICENSEREQ")]
    public partial class PChaseLicenseReq : PChaseLicenseReqBase
    {
    }
    }