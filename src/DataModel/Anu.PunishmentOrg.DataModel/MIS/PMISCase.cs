

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.MIS
{
    public abstract class PMISCaseBase : PunishmentOrgEntity<string>
    {

        [Column("ABSOLUTIONISSUED")]
        public virtual long? AbsolutionIssued { get; set; }

        [Column("ALLABSOLUTED")]
        public virtual long? AllAbsoluted { get; set; }

        [Column("ASSISTANCECOUNT")]
        public virtual long? AssistanceCount { get; set; }

        [Column("CASEARCHIVESTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUCaseArchiveState? CaseArchiveState { get; set; }

        [Unicode(false)]
        [Column("CASESTORENO")]
        public virtual string? CaseStoreNo { get; set; }

        [Column("CASETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUCaseType? CaseType { get; set; }

        [Column("CONVICTIONISSUED")]
        public virtual long? ConvictionIssued { get; set; }

        [Column("CONVICTIONPRICEFORGOVERMENT")]
        public virtual long? ConvictionPriceForGoverment { get; set; }

        [Column("CONVICTIONPRICEFORPLAINTIFF")]
        public virtual long? ConvictionPriceForPlaintiff { get; set; }

        [Column("COOPERATIONOFFENDINGCOUNT")]
        public virtual long? CooperationOffendingCount { get; set; }

        [Column("COPYCOUNT")]
        public virtual long? CopyCount { get; set; }

        [Column("CORRECTIVEJUDGECOUNT")]
        public virtual long? CorrectiveJudgeCount { get; set; }

        [Column("CREATECASETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUCreateCaseType? CreateCaseType { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("DAYSHASNOTTRIPLE")]
        public virtual long? DaysHasNotTriple { get; set; }

        [Column("DAYSNOTSENTTOEXECUTER")]
        public virtual long? DaysNotSentToExecuter { get; set; }

        [Column("DAYSOPENINCOURT")]
        public virtual long? DaysOpenInCourt { get; set; }

        [Column("DAYSOPENINEXECUTER")]
        public virtual long? DaysOpenInExecuter { get; set; }

        [Column("DIVANJUDGECOUNT")]
        public virtual long? DivanJudgeCount { get; set; }

        [Unicode(false)]
        [Column("ENDDATETIME")]
        public virtual string? EndDateTime { get; set; }

        [Column("EXECUTIONTIME")]
        public virtual long? ExecutionTime { get; set; }

        [Column("FEMALEOFFENDINGCOUNT")]
        public virtual long? FemaleOffendingCount { get; set; }

        [Column("FINESISSUED")]
        public virtual long? FinesIssued { get; set; }

        [Column("FOREIGNOFFENDINGCOUNT")]
        public virtual long? ForeignOffendingCount { get; set; }

        [Column("GOVERNMENTALOFFENDINGCOUNT")]
        public virtual long? GovernmentalOffendingCount { get; set; }

        [Column("GUILD")]
        public virtual Anu.PunishmentOrg.Enumerations.PUGuild? Guild { get; set; }

        [Column("HANDLETIME")]
        public virtual long? HandleTime { get; set; }

        [Column("HASCARDSTEWARDSHIPCOUNT")]
        public virtual long? HasCardStewardshipCount { get; set; }

        [Column("HASTIMENOT")]
        public virtual long? HasTimeNot { get; set; }

        [Column("IMPORTANCEDEGREE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUImportanceDegree? ImportanceDegree { get; set; }

        [Column("INPUTCOUNT")]
        public virtual long? InputCount { get; set; }

        [Column("INSTALLMENTSCOUNT")]
        public virtual long? InstallmentsCount { get; set; }

        [Column("INTERIMLICENSEOFFENDINGCOUNT")]
        public virtual long? InterimLicenseOffendingCount { get; set; }

        [Column("INVALIDITYISSUED")]
        public virtual long? InvalidityIssued { get; set; }

        [Column("ISGUILDCASE")]
        public virtual long? IsGuildCase { get; set; }

        [Column("ISHEALTHMEDICINECASE")]
        public virtual long? IsHealthMedicineCase { get; set; }

        [Column("ISRELATEDTOCURRENCY")]
        public virtual long? IsRelatedToCurrency { get; set; }

        [Column("ISRELATEDTOPRODUCT")]
        public virtual long? IsRelatedToProduct { get; set; }

        [Column("ISRELATEDTOSERVICESTYPE")]
        public virtual long? IsRelatedToServicesType { get; set; }

        [Column("ISSMUGGLINGCASE")]
        public virtual long? IsSmugglingCase { get; set; }

        [Column("LEASEDESTATECOUNT")]
        public virtual long? LeasedEstateCount { get; set; }

        [Column("LEGALOFFENDINGCOUNT")]
        public virtual long? LegalOffendingCount { get; set; }

        [Column("MAINJUDGECOUNT")]
        public virtual long? MainJudgeCount { get; set; }

        [Column("MAINJUDGEHASCORRECTIVECOUNT")]
        public virtual long? MainJudgeHasCorrectiveCount { get; set; }

        [Column("MALEOFFENDINGCOUNT")]
        public virtual long? MaleOffendingCount { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("NONGOVERNMENTALOFFENDINGCOUNT")]
        public virtual long? NonGovernmentalOffendingCount { get; set; }

        [Column("NOTPAIDINSTALLMENTSCOUNT")]
        public virtual long? NotPaidInstallmentsCount { get; set; }

        [Column("NOTPAIDINSTALLMENTSPRICE")]
        public virtual long? NotPaidInstallmentsPrice { get; set; }

        [Column("OFFENDINGCOUNT")]
        public virtual long? OffendingCount { get; set; }

        [Column("OTHERJUDGESUBJECTSISSUED")]
        public virtual long? OtherJudgeSubjectsIssued { get; set; }

        [Column("PAIDPRICE")]
        public virtual long? PaidPrice { get; set; }

        [Column("PARDONPRICE")]
        public virtual long? PardonPrice { get; set; }

        [Column("PARDONWRITISSUED")]
        public virtual long? PardonWritIssued { get; set; }

        [Column("PARTNERSHIPCOUNT")]
        public virtual long? PartnershipCount { get; set; }

        [Column("PERMANENTLICENSEOFFENDINGCOUNT")]
        public virtual long? PermanentLicenseOffendingCount { get; set; }

        [Column("PERSONALESTATECOUNT")]
        public virtual long? PersonalEstateCount { get; set; }

        [Column("PERSONCOUNT")]
        public virtual long? PersonCount { get; set; }

        [Column("PLAINTIFFCOUNT")]
        public virtual long? PlaintiffCount { get; set; }

        [Column("PRISONPRICE")]
        public virtual long? PrisonPrice { get; set; }

        [Column("PRISONWRITISSUED")]
        public virtual long? PrisonWritIssued { get; set; }

        [Column("PRIVATEORGOFFENDINGCOUNT")]
        public virtual long? PrivateOrgOffendingCount { get; set; }

        [Column("PRIVATESPECIALOFFENDINGCOUNT")]
        public virtual long? PrivateSpecialOffendingCount { get; set; }

        [Column("PUBLICAFFAIRSPRICE")]
        public virtual long? PublicAffairsPrice { get; set; }

        [Column("PUBLICAFFAIRSWRITISSUED")]
        public virtual long? PublicAffairsWritIssued { get; set; }

        [Column("REALOFFENDINGCOUNT")]
        public virtual long? RealOffendingCount { get; set; }

        [Column("REDUCEPRICE")]
        public virtual long? ReducePrice { get; set; }

        [Column("REDUCEWRITISSUED")]
        public virtual long? ReduceWritIssued { get; set; }

        [Unicode(false)]
        [Column("REFERESHDATETIME")]
        public virtual string? RefereshDateTime { get; set; }

        [Unicode(false)]
        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [Unicode(false)]
        [Column("STARTDATETIME")]
        public virtual string? StartDateTime { get; set; }

        [Column("STEWARDSHIPCOUNT")]
        public virtual long? StewardshipCount { get; set; }

        [Column("STOPCHASEPRICE")]
        public virtual long? StopChasePrice { get; set; }

        [Column("STOPCHASEWRITISSUED")]
        public virtual long? StopChaseWritIssued { get; set; }

        [Column("SUBNO")]
        public virtual long? SubNo { get; set; }

        [Column("TAJDIDJUDGECOUNT")]
        public virtual long? TajdidJudgeCount { get; set; }

        [Column("TERMINATEORDERISSUED")]
        public virtual long? TerminateOrderIssued { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("GUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.GUnitType? TheGUnitType { get; set; }

        [ForeignKey("NAJAUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

        [ForeignKey("PBCASESTOREID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBCaseStore? ThePBCaseStore { get; set; }

        [ForeignKey("PBREGULATORYPLANID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBRegulatoryPlan? ThePBRegulatoryPlan { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PMISCASECITYID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePMISCaseCity { get; set; }

        [ForeignKey("PMISCASECOMPLEXID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePMISCaseComplex { get; set; }

        [InverseProperty("ThePMISCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseInput>? ThePMISCaseInputList { get; set; }

        [ForeignKey("PMISCASEOSTANID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePMISCaseOstan { get; set; }

        [InverseProperty("ThePMISCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCasePerson>? ThePMISCasePersonList { get; set; }

        [ForeignKey("PMISCASESPECIALID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePMISCaseSpecial { get; set; }

        [InverseProperty("ThePMISCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseTriple>? ThePMISCaseTripleList { get; set; }

        [InverseProperty("ThePMISCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseViolation>? ThePMISCaseViolationList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("TOTALVIOLATIONPRICE")]
        public virtual long? TotalViolationPrice { get; set; }

        [Column("TOTALVIOLATIONPRICEBYCOURT")]
        public virtual long? TotalViolationPriceByCourt { get; set; }

        [Column("TOTALVIOLATIONPRICEBYEXPERT")]
        public virtual long? TotalViolationPriceByExpert { get; set; }

        [Column("TRIPLECOUNT")]
        public virtual long? TripleCount { get; set; }

        [Column("VIOLATIONCOUNT")]
        public virtual long? ViolationCount { get; set; }

        [Column("WRITISSUED")]
        public virtual long? WritIssued { get; set; }

    }

    [Table("PMISCASE")]
    public partial class PMISCase : PMISCaseBase
    {
    }
    }