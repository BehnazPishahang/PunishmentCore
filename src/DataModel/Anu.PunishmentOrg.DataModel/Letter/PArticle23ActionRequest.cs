

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PArticle23ActionRequestBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("CASEFLOW")]
        public virtual string? CaseFlow { get; set; }

        [Unicode(false)]
        [Column("CASENO")]
        public virtual string? CaseNo { get; set; }

        [Unicode(false)]
        [Column("CASERECEIVEDATE")]
        public virtual string? CaseReceiveDate { get; set; }

        [Column("CASESUBNO")]
        public virtual long? CaseSubNo { get; set; }

        [Column("CHECKINGRESULT")]
        public virtual Anu.BaseInfo.Enumerations.PArticleChekingResult? CheckingResult { get; set; }

        [Unicode(false)]
        [Column("CHIEFASSESSMENT")]
        public virtual string? ChiefAssessment { get; set; }

        [Column("CHIEFORDER")]
        public virtual Anu.BaseInfo.Enumerations.PArticle50ChiefOrder? ChiefOrder { get; set; }

        [Unicode(false)]
        [Column("CONDEMNEDFAMILY")]
        public virtual string? CondemnedFamily { get; set; }

        [Unicode(false)]
        [Column("CONDEMNEDMOBILNUMBER")]
        public virtual string? CondemnedMobilNumber { get; set; }

        [Unicode(false)]
        [Column("CONDEMNEDNAME")]
        public virtual string? CondemnedName { get; set; }

        [Unicode(false)]
        [Column("CONDEMNEDNATIONALCODE")]
        public virtual string? CondemnedNationalCode { get; set; }

        [Unicode(false)]
        [Column("CONSULTANTASSESSMENT")]
        public virtual string? ConsultantAssessment { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("DEMANDANTPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.Article23Demandant? DemandantPost { get; set; }

        [Unicode(false)]
        [Column("EXPERTASSESSMENT")]
        public virtual string? ExpertAssessment { get; set; }

        [Column("FINALSTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.Article23FinalState? FinalState { get; set; }

        [Unicode(false)]
        [Column("HEADASSESSMENT")]
        public virtual string? HeadAssessment { get; set; }

        [Unicode(false)]
        [Column("HEADASSESSMENTFORCHIEF")]
        public virtual string? HeadAssessmentForChief { get; set; }

        [Column("ISMECHANIZE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsMechanize { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("PLANNEDOBJECTION")]
        public virtual Anu.BaseInfo.Enumerations.PlannedObjection? PlannedObjection { get; set; }

        [Unicode(false)]
        [Column("PROVINCERESPONSE")]
        public virtual string? ProvinceResponse { get; set; }

        [Unicode(false)]
        [Column("RELATEDJUDGEDATE")]
        public virtual string? RelatedJudgeDate { get; set; }

        [Unicode(false)]
        [Column("RELATEDJUDGENO")]
        public virtual string? RelatedJudgeNo { get; set; }

        [Unicode(false)]
        [Column("REQUESTREASON")]
        public virtual string? RequestReason { get; set; }

        [Column("REQUESTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.Article23RequestType? RequestType { get; set; }

        [Unicode(false)]
        [Column("SIDENOTE")]
        public virtual string? SideNote { get; set; }

        [ForeignKey("CONDEMNEDPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? TheCondemnedPerson { get; set; }

        [ForeignKey("CONSULTANTEXPERTID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheConsultantExpert { get; set; }

        [ForeignKey("JUDGEEXPERTID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheJudgeExpert { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePArticle23ActionRequest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PArticle23ActionReqAttach>? ThePArticle23ActionReqAttachList { get; set; }

        [InverseProperty("ThePArticle23ActionRequest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PArticle23ActionRequestUnit>? ThePArticle23ActionRequestUnitList { get; set; }

        [InverseProperty("ThePArticle23ActionRequest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PArticle23Assessment>? ThePArticle23AssessmentList { get; set; }

        [ForeignKey("RELATEDCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? TheRelatedCase { get; set; }

        [ForeignKey("RELATEDJUDGEID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? TheRelatedJudge { get; set; }

        [ForeignKey("RELATEDJUDGEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheRelatedJudgeUnit { get; set; }

        [ForeignKey("REQUESTRECIPIENTUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheRequestRecipientUnit { get; set; }

        [ForeignKey("SUPERIORCOURTID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheSuperiorCourt { get; set; }

        [Column("UNITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.Article23UnitType? UnitType { get; set; }

    }

    [Table("PARTICLE23ACTIONREQUEST")]
    public partial class PArticle23ActionRequest : PArticle23ActionRequestBase
    {
    }
    }