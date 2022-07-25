

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.MIS
{
    public abstract class PMISCasePersonBase : PunishmentOrgEntity<string>
    {

        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Column("CARDSTEWARDSHIPDATE")]
        public virtual string? CardStewardshipDate { get; set; }

        [Column("HASCARDSTEWARDSHIP")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? HasCardStewardship { get; set; }

        [Column("LEGALPERSONSTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULegalPersonState? LegalPersonState { get; set; }

        [Column("LICENSEOWNERBIRTHDATE")]
        public virtual string? LicenseOwnerBirthDate { get; set; }

        [Column("LICENSEOWNERSEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? LicenseOwnerSex { get; set; }

        [Column("LICENSETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULicenseType? LicenseType { get; set; }

        [Column("LIFESTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULifeState? LifeState { get; set; }

        [Column("NATIONALITY")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

        [Column("OWNERESTATETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnerEstateType? OwnerEstateType { get; set; }

        [Column("OWNERSHIPTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUOwnershipType? OwnershipType { get; set; }

        [Column("PERSONSTARTPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.PUPersonStartPost? PersonStartPost { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("RELIGION")]
        public virtual Anu.BaseInfo.Enumerations.LReligion? Religion { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [ForeignKey("AGENTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.AgentType? TheAgentType { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [InverseProperty("TheOffendingPerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseTriple>? TheOffendingTripleList { get; set; }

        [ForeignKey("PBTRADEUNIONSID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTradeUnions? ThePBTradeUnions { get; set; }

        [ForeignKey("PBTRADEUNITTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTradeUnitType? ThePBTradeUnitType { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [InverseProperty("ThePlaintiffPerson")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseTriple>? ThePlaintiffTripleList { get; set; }

        [ForeignKey("PMISCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCase? ThePMISCase { get; set; }

        [Column("TRADELICENSEDATE")]
        public virtual string? TradeLicenseDate { get; set; }

    }

    [Table("PMISCASEPERSON")]
    public partial class PMISCasePerson : PMISCasePersonBase
    {
    }
}