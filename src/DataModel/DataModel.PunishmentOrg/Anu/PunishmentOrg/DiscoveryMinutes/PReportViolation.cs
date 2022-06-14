

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PReportViolationBase : PunishmentOrgEntity<string>
    {

		[Column("BILLNOPRODUCTORDOCFOUND")]
		public virtual string? BillNoProductOrDocFound { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CRIMESANDVIOLATIONSSEEN")]
		public virtual string? CrimesAndViolationsSeen { get; set; }

		[Column("DISCOVERYPLACELICENSENUMBER")]
		public virtual string? DiscoveryPlacelicenseNumber { get; set; }

		[Column("DISCOVERYPLACEOWNER")]
		public virtual string? DiscoveryPlaceOwner { get; set; }

		[Column("EVIDENCEPOSSIBILITY")]
		public virtual string? EvidencePossibility { get; set; }

		[Column("HAVEPLACELICENSENUMBER")]
		public virtual Anu.Enumerations.HaveNoHave? HavePlacelicenseNumber { get; set; }

		[Column("INSTITUTIONCODE")]
		public virtual string? InstitutionCode { get; set; }

		[Column("INSTITUTIONEXPORTER")]
		public virtual Anu.Enumerations.PunishmentOrg.DiscoveryMinutesCompetenceReference? InstitutionExporter { get; set; }

		[Column("INSTITUTIONTITLE")]
		public virtual string? InstitutionTitle { get; set; }

		[Column("PLACEADDRESS")]
		public virtual string? PlaceAddress { get; set; }

		[Column("PLACEPHONENUM")]
		public virtual string? PlacePhoneNum { get; set; }

		[Column("PLACEPLAQUE")]
		public virtual string? PlacePlaque { get; set; }

		[Column("PLACEPOSTALCODE")]
		public virtual string? PlacePostalCode { get; set; }

		[Column("PLACEUNITNAME")]
		public virtual string? PlaceUnitName { get; set; }

		[Column("REPORTTEXT")]
		public virtual string? ReportText { get; set; }

		[Column("REPORTTIME")]
		public virtual string? ReportTime { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[ForeignKey("JUDICIALUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? TheJudicialUnit { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PCHASELICENSEREQID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

		[InverseProperty("ThePReportViolation")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PReportViolationAttach>? ThePReportViolationAttachList { get; set; }

		[InverseProperty("ThePReportViolation")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PReportViolationOfficer>? ThePReportViolationOfficerList { get; set; }

		[InverseProperty("ThePReportViolation")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PReportViolationSuspect>? ThePReportViolationSuspectList { get; set; }

		[InverseProperty("ThePReportViolation")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PReportViolationUnit>? ThePReportViolationUnitList { get; set; }

		[InverseProperty("ThePReportViolation")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PReportViolationVehicle>? ThePReportViolationVehicleList { get; set; }

		[ForeignKey("REFERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheReferUnit { get; set; }

		[ForeignKey("REPORTERID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? TheReporter { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("UNIQUENO")]
		public virtual string? UniqueNo { get; set; }

    }
    [Table("PREPORTVIOLATION")]
    public partial class PReportViolation : PReportViolationBase { }

    }


