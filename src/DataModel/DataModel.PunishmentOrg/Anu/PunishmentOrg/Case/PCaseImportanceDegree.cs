

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PCaseImportanceDegreeBase : PunishmentOrgEntity<string>
    {

		[Column("EXECUTEPRISON")]
		public virtual Anu.Enumerations.YesNo? ExecutePrison { get; set; }

		[Column("EXECUTEPRISONCHANGE")]
		public virtual Anu.Enumerations.YesNo? ExecutePrisonChange { get; set; }

		[Column("FAMOUSPERSON")]
		public virtual Anu.Enumerations.YesNo? FamousPerson { get; set; }

		[Column("GUILDCASECOLLECTING")]
		public virtual Anu.Enumerations.YesNo? GuildCaseCollecting { get; set; }

		[Column("GUILDCASECONVICTION")]
		public virtual Anu.Enumerations.YesNo? GuildCaseConviction { get; set; }

		[Column("GUILDCASECURRENCY")]
		public virtual Anu.Enumerations.YesNo? GuildCaseCurrency { get; set; }

		[Column("GUILDCASEDEPOSIT")]
		public virtual Anu.Enumerations.YesNo? GuildCasedeposit { get; set; }

		[Column("GUILDCASEFACTORY")]
		public virtual Anu.Enumerations.YesNo? GuildCaseFactory { get; set; }

		[Column("GUILDCASEFUNDAMENTAL")]
		public virtual Anu.Enumerations.YesNo? GuildCaseFundamental { get; set; }

		[Column("GUILDCASEGOVERMENTAL")]
		public virtual Anu.Enumerations.YesNo? GuildCaseGovermental { get; set; }

		[Column("GUILDCASEGRAVAMEN")]
		public virtual Anu.Enumerations.YesNo? GuildCaseGravamen { get; set; }

		[Column("GUILDCASEPRIVATE")]
		public virtual Anu.Enumerations.YesNo? GuildCasePrivate { get; set; }

		[Column("GUILDCASESELLING")]
		public virtual Anu.Enumerations.YesNo? GuildCaseSelling { get; set; }

		[Column("GUILDCASESERVICE")]
		public virtual Anu.Enumerations.YesNo? GuildCaseService { get; set; }

		[Column("IMPORTANCEDESCRIPTION")]
		public virtual string? ImportanceDescription { get; set; }

		[Column("MEDICINECASECANCELLATION")]
		public virtual Anu.Enumerations.YesNo? MedicineCaseCancellation { get; set; }

		[Column("MEDICINECASECLOSING")]
		public virtual Anu.Enumerations.YesNo? MedicineCaseClosing { get; set; }

		[Column("MEDICINECASECOLLECTING")]
		public virtual Anu.Enumerations.YesNo? MedicineCaseCollecting { get; set; }

		[Column("MEDICINECASEEXTINCTION")]
		public virtual Anu.Enumerations.YesNo? MedicineCaseExtinction { get; set; }

		[Column("MEDICINECASEFACTORY")]
		public virtual Anu.Enumerations.YesNo? MedicineCaseFactory { get; set; }

		[Column("MEDICINECASEGOVERMENTAL")]
		public virtual Anu.Enumerations.YesNo? MedicineCaseGovermental { get; set; }

		[Column("MEDICINECASEGOVEXTINCTION")]
		public virtual Anu.Enumerations.YesNo? MedicineCaseGovExtinction { get; set; }

		[Column("MEDICINECASEHOSPITAL")]
		public virtual Anu.Enumerations.YesNo? MedicineCaseHospital { get; set; }

		[Column("MEDICINECASEPERSON")]
		public virtual Anu.Enumerations.YesNo? MedicineCasePerson { get; set; }

		[Column("MEDICINECASEPRICE")]
		public virtual Anu.Enumerations.YesNo? MedicineCasePrice { get; set; }

		[Column("MEDICINECASEPRIVATE")]
		public virtual Anu.Enumerations.YesNo? MedicineCasePrivate { get; set; }

		[Column("NATIONALRIGHTS")]
		public virtual Anu.Enumerations.YesNo? NationalRights { get; set; }

		[Column("SMUGGLINGCASEGOODS")]
		public virtual Anu.Enumerations.YesNo? SmugglingCaseGoods { get; set; }

		[Column("SMUGGLINGCASEINCURRENCY")]
		public virtual Anu.Enumerations.YesNo? SmugglingCaseInCurrency { get; set; }

		[Column("SMUGGLINGCASELAW18")]
		public virtual Anu.Enumerations.YesNo? SmugglingCaseLaw18 { get; set; }

		[Column("SMUGGLINGCASEOUTCURRENCY")]
		public virtual Anu.Enumerations.YesNo? SmugglingCaseOutCurrency { get; set; }

		[Column("SMUGGLINGCASEPRICE2")]
		public virtual Anu.Enumerations.YesNo? SmugglingCasePrice2 { get; set; }

		[Column("SMUGGLINGCASEPRICE3")]
		public virtual Anu.Enumerations.YesNo? SmugglingCasePrice3 { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

    }
    [Table("PCASEIMPORTANCEDEGREE")]
    public partial class PCaseImportanceDegree : PCaseImportanceDegreeBase { }

    }


