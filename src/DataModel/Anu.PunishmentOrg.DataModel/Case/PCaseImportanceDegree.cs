

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseImportanceDegreeBase : PunishmentOrgEntity<string>
    {

        [Column("EXECUTEPRISON")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ExecutePrison { get; set; }

        [Column("EXECUTEPRISONCHANGE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ExecutePrisonChange { get; set; }

        [Column("FAMOUSPERSON")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? FamousPerson { get; set; }

        [Column("GUILDCASECOLLECTING")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseCollecting { get; set; }

        [Column("GUILDCASECONVICTION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseConviction { get; set; }

        [Column("GUILDCASECURRENCY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseCurrency { get; set; }

        [Column("GUILDCASEDEPOSIT")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCasedeposit { get; set; }

        [Column("GUILDCASEFACTORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseFactory { get; set; }

        [Column("GUILDCASEFUNDAMENTAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseFundamental { get; set; }

        [Column("GUILDCASEGOVERMENTAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseGovermental { get; set; }

        [Column("GUILDCASEGRAVAMEN")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseGravamen { get; set; }

        [Column("GUILDCASEPRIVATE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCasePrivate { get; set; }

        [Column("GUILDCASESELLING")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseSelling { get; set; }

        [Column("GUILDCASESERVICE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? GuildCaseService { get; set; }

        [Unicode(false)]
        [Column("IMPORTANCEDESCRIPTION")]
        public virtual string? ImportanceDescription { get; set; }

        [Column("MEDICINECASECANCELLATION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCaseCancellation { get; set; }

        [Column("MEDICINECASECLOSING")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCaseClosing { get; set; }

        [Column("MEDICINECASECOLLECTING")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCaseCollecting { get; set; }

        [Column("MEDICINECASEEXTINCTION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCaseExtinction { get; set; }

        [Column("MEDICINECASEFACTORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCaseFactory { get; set; }

        [Column("MEDICINECASEGOVERMENTAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCaseGovermental { get; set; }

        [Column("MEDICINECASEGOVEXTINCTION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCaseGovExtinction { get; set; }

        [Column("MEDICINECASEHOSPITAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCaseHospital { get; set; }

        [Column("MEDICINECASEPERSON")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCasePerson { get; set; }

        [Column("MEDICINECASEPRICE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCasePrice { get; set; }

        [Column("MEDICINECASEPRIVATE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? MedicineCasePrivate { get; set; }

        [Column("NATIONALRIGHTS")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? NationalRights { get; set; }

        [Column("SMUGGLINGCASEGOODS")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SmugglingCaseGoods { get; set; }

        [Column("SMUGGLINGCASEINCURRENCY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SmugglingCaseInCurrency { get; set; }

        [Column("SMUGGLINGCASELAW18")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SmugglingCaseLaw18 { get; set; }

        [Column("SMUGGLINGCASEOUTCURRENCY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SmugglingCaseOutCurrency { get; set; }

        [Column("SMUGGLINGCASEPRICE2")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SmugglingCasePrice2 { get; set; }

        [Column("SMUGGLINGCASEPRICE3")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SmugglingCasePrice3 { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

    }

    [Table("PCASEIMPORTANCEDEGREE")]
    public partial class PCaseImportanceDegree : PCaseImportanceDegreeBase
    {
    }
    }