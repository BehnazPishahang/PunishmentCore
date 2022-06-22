

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseImportanceDegreeBase : PunishmentOrgEntity<string>
    {

		[Column("EXECUTEPRISON")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? ExecutePrison { get; set; }

		[Column("EXECUTEPRISONCHANGE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? ExecutePrisonChange { get; set; }

		[Column("FAMOUSPERSON")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? FamousPerson { get; set; }

		[Column("GUILDCASECOLLECTING")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseCollecting { get; set; }

		[Column("GUILDCASECONVICTION")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseConviction { get; set; }

		[Column("GUILDCASECURRENCY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseCurrency { get; set; }

		[Column("GUILDCASEDEPOSIT")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCasedeposit { get; set; }

		[Column("GUILDCASEFACTORY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseFactory { get; set; }

		[Column("GUILDCASEFUNDAMENTAL")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseFundamental { get; set; }

		[Column("GUILDCASEGOVERMENTAL")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseGovermental { get; set; }

		[Column("GUILDCASEGRAVAMEN")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseGravamen { get; set; }

		[Column("GUILDCASEPRIVATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCasePrivate { get; set; }

		[Column("GUILDCASESELLING")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseSelling { get; set; }

		[Column("GUILDCASESERVICE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? GuildCaseService { get; set; }

		[Column("IMPORTANCEDESCRIPTION")]
		public virtual string? ImportanceDescription { get; set; }

		[Column("MEDICINECASECANCELLATION")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCaseCancellation { get; set; }

		[Column("MEDICINECASECLOSING")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCaseClosing { get; set; }

		[Column("MEDICINECASECOLLECTING")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCaseCollecting { get; set; }

		[Column("MEDICINECASEEXTINCTION")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCaseExtinction { get; set; }

		[Column("MEDICINECASEFACTORY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCaseFactory { get; set; }

		[Column("MEDICINECASEGOVERMENTAL")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCaseGovermental { get; set; }

		[Column("MEDICINECASEGOVEXTINCTION")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCaseGovExtinction { get; set; }

		[Column("MEDICINECASEHOSPITAL")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCaseHospital { get; set; }

		[Column("MEDICINECASEPERSON")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCasePerson { get; set; }

		[Column("MEDICINECASEPRICE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCasePrice { get; set; }

		[Column("MEDICINECASEPRIVATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? MedicineCasePrivate { get; set; }

		[Column("NATIONALRIGHTS")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? NationalRights { get; set; }

		[Column("SMUGGLINGCASEGOODS")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? SmugglingCaseGoods { get; set; }

		[Column("SMUGGLINGCASEINCURRENCY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? SmugglingCaseInCurrency { get; set; }

		[Column("SMUGGLINGCASELAW18")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? SmugglingCaseLaw18 { get; set; }

		[Column("SMUGGLINGCASEOUTCURRENCY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? SmugglingCaseOutCurrency { get; set; }

		[Column("SMUGGLINGCASEPRICE2")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? SmugglingCasePrice2 { get; set; }

		[Column("SMUGGLINGCASEPRICE3")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? SmugglingCasePrice3 { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

    }
    [Table("PCASEIMPORTANCEDEGREE")]
    public partial class PCaseImportanceDegree : PCaseImportanceDegreeBase { }

    }


