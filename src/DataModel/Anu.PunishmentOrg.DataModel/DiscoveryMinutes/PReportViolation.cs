using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PReportViolationBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("BILLNOPRODUCTORDOCFOUND")]
        public virtual string? BillNoProductOrDocFound { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("CRIMESANDVIOLATIONSSEEN")]
        public virtual string? CrimesAndViolationsSeen { get; set; }

        [Unicode(false)]
        [Column("DISCOVERYPLACELICENSENUMBER")]
        public virtual string? DiscoveryPlacelicenseNumber { get; set; }

        [Unicode(false)]
        [Column("DISCOVERYPLACEOWNER")]
        public virtual string? DiscoveryPlaceOwner { get; set; }

        [Unicode(false)]
        [Column("EVIDENCEPOSSIBILITY")]
        public virtual string? EvidencePossibility { get; set; }

        [Column("HAVEPLACELICENSENUMBER")]
        public virtual Anu.BaseInfo.Enumerations.HaveNoHave? HavePlacelicenseNumber { get; set; }

        [Unicode(false)]
        [Column("INSTITUTIONCODE")]
        public virtual string? InstitutionCode { get; set; }

        [Column("INSTITUTIONEXPORTER")]
        public virtual Anu.PunishmentOrg.Enumerations.DiscoveryMinutesCompetenceReference? InstitutionExporter { get; set; }

        [Unicode(false)]
        [Column("INSTITUTIONTITLE")]
        public virtual string? InstitutionTitle { get; set; }

        [Unicode(false)]
        [Column("PLACEADDRESS")]
        public virtual string? PlaceAddress { get; set; }

        [Unicode(false)]
        [Column("PLACEPHONENUM")]
        public virtual string? PlacePhoneNum { get; set; }

        [Unicode(false)]
        [Column("PLACEPLAQUE")]
        public virtual string? PlacePlaque { get; set; }

        [Unicode(false)]
        [Column("PLACEPOSTALCODE")]
        public virtual string? PlacePostalCode { get; set; }

        [Unicode(false)]
        [Column("PLACEUNITNAME")]
        public virtual string? PlaceUnitName { get; set; }

        [Unicode(false)]
        [Column("REPORTTEXT")]
        public virtual string? ReportText { get; set; }

        [Unicode(false)]
        [Column("REPORTTIME")]
        public virtual string? ReportTime { get; set; }

        [Unicode(false)]
        [Column("SENDDATETIME")]
        public virtual string? SendDateTime { get; set; }

        [ForeignKey("JUDICIALUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? TheJudicialUnit { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

        [InverseProperty("ThePReportViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolationAttach>? ThePReportViolationAttachList { get; set; }

        [InverseProperty("ThePReportViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolationOfficer>? ThePReportViolationOfficerList { get; set; }

        [InverseProperty("ThePReportViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolationSuspect>? ThePReportViolationSuspectList { get; set; }

        [InverseProperty("ThePReportViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolationUnit>? ThePReportViolationUnitList { get; set; }

        [InverseProperty("ThePReportViolation")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolationVehicle>? ThePReportViolationVehicleList { get; set; }

        [ForeignKey("REFERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReferUnit { get; set; }

        [ForeignKey("REPORTERID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? TheReporter { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Unicode(false)]
        [Column("UNIQUENO")]
        public virtual string? UniqueNo { get; set; }

        }

    [Table("PREPORTVIOLATION")]
    public partial class PReportViolation : PReportViolationBase
    {
    }
    }