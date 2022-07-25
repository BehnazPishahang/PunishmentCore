

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCasePersonBase : PunishmentOrgEntity<string>
    {

        [Column("ADDINGACCUSEDDATE")]
        public virtual string? AddingAccusedDate { get; set; }

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Column("CARDSTEWARDSHIPDATE")]
        public virtual string? CardStewardshipDate { get; set; }

        [Column("CARDSTEWARDSHIPNO")]
        public virtual string? CardStewardshipNo { get; set; }

        [Column("COMPANYTYPE")]
        public virtual string? CompanyType { get; set; }

        [Column("DAMAGECAUSEDVALUE")]
        public virtual long? DamageCausedValue { get; set; }

        [Column("EMAIL")]
        public virtual string? EMail { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("GOVORGOWNER")]
        public virtual string? GovOrgOwner { get; set; }

        [Column("HASCARDSTEWARDSHIP")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? HasCardStewardship { get; set; }

        [Column("IDENTITYNUMBER")]
        public virtual string? IdentityNumber { get; set; }

        [Column("ISSEARCHHISTORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsSearchHistory { get; set; }

        [Column("JOBTITLE")]
        public virtual string? JobTitle { get; set; }

        [Column("LEGALPERSONSTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULegalPersonState? LegalPersonState { get; set; }

        [Column("LICENSEOWNERBIRTHDATE")]
        public virtual string? LicenseOwnerBirthDate { get; set; }

        [Column("LICENSEOWNERFAMILY")]
        public virtual string? LicenseOwnerFamily { get; set; }

        [Column("LICENSEOWNERNAME")]
        public virtual string? LicenseOwnerName { get; set; }

        [Column("LICENSEOWNERNATIONALCODE")]
        public virtual string? LicenseOwnerNationalCode { get; set; }

        [Column("LICENSEOWNERSEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? LicenseOwnerSex { get; set; }

        [Column("LICENSETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULicenseType? LicenseType { get; set; }

        [Column("LIFESTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULifeState? LifeState { get; set; }

        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("NATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

        [Column("OWNERESTATETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnerEstateType? OwnerEstateType { get; set; }

        [Column("OWNERSHIPTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUOwnershipType? OwnershipType { get; set; }

        [Column("PERSONPASSWORD")]
        public virtual string? PersonPassword { get; set; }

        [Column("PERSONSTARTPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.PUPersonStartPost? PersonStartPost { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("PHONENUMBER")]
        public virtual string? PhoneNumber { get; set; }

        [Column("POSTCODE")]
        public virtual string? PostCode { get; set; }

        [Column("RELIGION")]
        public virtual Anu.BaseInfo.Enumerations.LReligion? Religion { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [InverseProperty("TheAgent")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseAgent>? TheAgentedsList { get; set; }

        [InverseProperty("TheAgented")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseAgent>? TheAgentsList { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("GLAWYERID")]
        public virtual Anu.BaseInfo.DataModel.Lawyer.GLawyer? TheGLawyer { get; set; }

        [ForeignKey("NATIONALITYLOCID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheNationalityLoc { get; set; }

        [InverseProperty("TheOffendingPerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseTriple>? TheOffendingTripleList { get; set; }

        [InverseProperty("TheArrestedPerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PArrested>? ThePArrestedList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PBill4Paid>? ThePBill4PaidList { get; set; }

        [ForeignKey("PBTRADEUNIONSID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTradeUnions? ThePBTradeUnions { get; set; }

        [ForeignKey("PBTRADEUNITTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTradeUnitType? ThePBTradeUnitType { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PCancelSaftyWrit>? ThePCancelSaftyWritList { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubjectPrsn>? ThePCaseBindingSubjectPrsnList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseProductPerson>? ThePCaseProductPersonList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseVehiclePerson>? ThePCaseVehiclePersonList { get; set; }

        [InverseProperty("ThePaidCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCash>? ThePCashList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionRemovalWrit>? ThePExecutionRemovalWritList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionWrit>? ThePExecutionWritList { get; set; }

        [InverseProperty("TheSentencedPerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PInstallment>? ThePInstallmentList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubjectPrsn>? ThePJudgmentBindingSubjectPrsnList { get; set; }

        [InverseProperty("ThePlaintiffPerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseTriple>? ThePlaintiffTripleList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticePerson>? ThePNoticePersonList { get; set; }

        [InverseProperty("ThePrisonPerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPrisoner>? ThePPrisonerList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPublicWorksExec>? ThePPublicWorksExecList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PRevisionRequestAsker>? ThePRevisionRequestAskerList { get; set; }

        [InverseProperty("ThePCasePerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWrit>? ThePSaftyWritList { get; set; }

        [Column("TRADELICENSE")]
        public virtual Anu.PunishmentOrg.Enumerations.LicenseType? TradeLicense { get; set; }

        [Column("TRADELICENSEDATE")]
        public virtual string? TradeLicenseDate { get; set; }

        [Column("TRADELICENSENUMBER")]
        public virtual string? TradeLicenseNumber { get; set; }

        [Column("TRADEUNITIDENTITYNUMBER")]
        public virtual string? TradeUnitIdentityNumber { get; set; }

        [Column("TRADEUNITNAME")]
        public virtual string? TradeUnitName { get; set; }

    }

    [Table("PCASEPERSON")]
    public partial class PCasePerson : PCasePersonBase
    {
    }
}