

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PExecutionWritBase : PunishmentOrgEntity<string>
    {

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("CONFIRMERPOSTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DEBTREDUCTIONPERCENT")]
		public virtual long? DebtReductionPercent { get; set; }

		[Column("DEBTREDUCTIONVALUE")]
		public virtual long? DebtReductionValue { get; set; }

		[Column("ENDWRITDATE")]
		public virtual string? EndWritDate { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("IDENTITYNUMBER")]
		public virtual string? IdentityNumber { get; set; }

		[Column("JUDNO")]
		public virtual string? JudNo { get; set; }

		[Column("LEGALDOC4DEBT")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PLegalDoc4Debt? LegalDoc4Debt { get; set; }

		[Column("MANUALNO")]
		public virtual string? ManualNo { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PASSPORTOFFICERDESC")]
		public virtual string? PAssportOfficerDesc { get; set; }

		[Column("PROSECUTORREJECTREASON")]
		public virtual string? ProsecutorRejectReason { get; set; }

		[Column("SEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? Sex { get; set; }

		[Column("STARTWRITDATE")]
		public virtual string? StartWritDate { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PBFORGIVENESSTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBForgivenessType? ThePBForgivenessType { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[InverseProperty("ThePExecutionWrit")]
		public virtual List<Anu.PunishmentOrg.Execution.PExecutionRemovalWrit>? ThePExecutionRemovalWritList { get; set; }

		[InverseProperty("ThePExecutionWrit")]
		public virtual List<Anu.PunishmentOrg.Execution.PExecutionWritAccount>? ThePExecutionWritAccountList { get; set; }

		[InverseProperty("ThePExecutionWrit")]
		public virtual List<Anu.PunishmentOrg.Execution.PExecutionWritBindingSbjt>? ThePExecutionWritBindingSbjtList { get; set; }

		[InverseProperty("ThePExecutionWrit")]
		public virtual List<Anu.PunishmentOrg.Execution.PExecutionWritUnit>? ThePExecutionWritUnitList { get; set; }

		[ForeignKey("PRIMITIVEWRITID")]
		public virtual Anu.PunishmentOrg.Execution.PExecutionWrit? ThePrimitiveWrit { get; set; }

		[InverseProperty("ThePrimitiveWrit")]
		public virtual List<Anu.PunishmentOrg.Execution.PExecutionWrit>? TheRecentWritsList { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TRAVELBANENDTIME")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PTravelBanEndTime? TravelBanEndTime { get; set; }

		[Column("WRITTEXT")]
		public virtual string? WritText { get; set; }

		[Column("WRITTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUExecutionWritType? WritType { get; set; }

    }
    [Table("PEXECUTIONWRIT")]
    public partial class PExecutionWrit : PExecutionWritBase { }

    }


