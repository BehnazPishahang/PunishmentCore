

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PExecutionWritBase : PunishmentOrgEntity<string>
    {

        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Column("CONFIRMERPOSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

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
        public virtual Anu.PunishmentOrg.Enumerations.PLegalDoc4Debt? LegalDoc4Debt { get; set; }

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
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [Column("STARTWRITDATE")]
        public virtual string? StartWritDate { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBFORGIVENESSTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBForgivenessType? ThePBForgivenessType { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [InverseProperty("ThePExecutionWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionRemovalWrit>? ThePExecutionRemovalWritList { get; set; }

        [InverseProperty("ThePExecutionWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionWritAccount>? ThePExecutionWritAccountList { get; set; }

        [InverseProperty("ThePExecutionWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionWritBindingSbjt>? ThePExecutionWritBindingSbjtList { get; set; }

        [InverseProperty("ThePExecutionWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionWritUnit>? ThePExecutionWritUnitList { get; set; }

        [ForeignKey("PRIMITIVEWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PExecutionWrit? ThePrimitiveWrit { get; set; }

        [InverseProperty("ThePrimitiveWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionWrit>? TheRecentWritsList { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("TRAVELBANENDTIME")]
        public virtual Anu.PunishmentOrg.Enumerations.PTravelBanEndTime? TravelBanEndTime { get; set; }

        [Column("WRITTEXT")]
        public virtual string? WritText { get; set; }

        [Column("WRITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUExecutionWritType? WritType { get; set; }

    }

    [Table("PEXECUTIONWRIT")]
    public partial class PExecutionWrit : PExecutionWritBase
    {
    }
}