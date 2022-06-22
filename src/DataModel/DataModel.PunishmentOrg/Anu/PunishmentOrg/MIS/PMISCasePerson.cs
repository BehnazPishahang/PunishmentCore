

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.MIS
{
    public abstract class PMISCasePersonBase : PunishmentOrgEntity<string>
    {

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("CARDSTEWARDSHIPDATE")]
		public virtual string? CardStewardshipDate { get; set; }

		[Column("HASCARDSTEWARDSHIP")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? HasCardStewardship { get; set; }

		[Column("LEGALPERSONSTATE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PULegalPersonState? LegalPersonState { get; set; }

		[Column("LICENSEOWNERBIRTHDATE")]
		public virtual string? LicenseOwnerBirthDate { get; set; }

		[Column("LICENSEOWNERSEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? LicenseOwnerSex { get; set; }

		[Column("LICENSETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PULicenseType? LicenseType { get; set; }

		[Column("LIFESTATE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PULifeState? LifeState { get; set; }

		[Column("NATIONALITY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.LNationality? Nationality { get; set; }

		[Column("OWNERESTATETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.OwnerEstateType? OwnerEstateType { get; set; }

		[Column("OWNERSHIPTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUOwnershipType? OwnershipType { get; set; }

		[Column("PERSONSTARTPOST")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUPersonStartPost? PersonStartPost { get; set; }

		[Column("PERSONTYPE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.PersonType? PersonType { get; set; }

		[Column("RELIGION")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.LReligion? Religion { get; set; }

		[Column("SEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? Sex { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[ForeignKey("AGENTTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.AgentType? TheAgentType { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[InverseProperty("TheOffendingPerson")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseTriple>? TheOffendingTripleList { get; set; }

		[ForeignKey("PBTRADEUNIONSID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBTradeUnions? ThePBTradeUnions { get; set; }

		[ForeignKey("PBTRADEUNITTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBTradeUnitType? ThePBTradeUnitType { get; set; }

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[InverseProperty("ThePlaintiffPerson")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseTriple>? ThePlaintiffTripleList { get; set; }

		[ForeignKey("PMISCASEID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCase? ThePMISCase { get; set; }

		[Column("TRADELICENSEDATE")]
		public virtual string? TradeLicenseDate { get; set; }

    }
    [Table("PMISCASEPERSON")]
    public partial class PMISCasePerson : PMISCasePersonBase { }

    }


