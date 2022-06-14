

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class PArticle23ActionRequestBase : PunishmentOrgEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CASEFLOW")]
		public virtual string? CaseFlow { get; set; }

		[Column("CASENO")]
		public virtual string? CaseNo { get; set; }

		[Column("CASERECEIVEDATE")]
		public virtual string? CaseReceiveDate { get; set; }

		[Column("CASESUBNO")]
		public virtual long? CaseSubNo { get; set; }

		[Column("CHECKINGRESULT")]
		public virtual Anu.Enumerations.PArticleChekingResult? CheckingResult { get; set; }

		[Column("CHIEFASSESSMENT")]
		public virtual string? ChiefAssessment { get; set; }

		[Column("CHIEFORDER")]
		public virtual Anu.Enumerations.PArticle50ChiefOrder? ChiefOrder { get; set; }

		[Column("CONDEMNEDFAMILY")]
		public virtual string? CondemnedFamily { get; set; }

		[Column("CONDEMNEDMOBILNUMBER")]
		public virtual string? CondemnedMobilNumber { get; set; }

		[Column("CONDEMNEDNAME")]
		public virtual string? CondemnedName { get; set; }

		[Column("CONDEMNEDNATIONALCODE")]
		public virtual string? CondemnedNationalCode { get; set; }

		[Column("CONSULTANTASSESSMENT")]
		public virtual string? ConsultantAssessment { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DEMANDANTPOST")]
		public virtual Anu.Enumerations.PunishmentOrg.Article23Demandant? DemandantPost { get; set; }

		[Column("EXPERTASSESSMENT")]
		public virtual string? ExpertAssessment { get; set; }

		[Column("FINALSTATE")]
		public virtual Anu.Enumerations.PunishmentOrg.Article23FinalState? FinalState { get; set; }

		[Column("HEADASSESSMENT")]
		public virtual string? HeadAssessment { get; set; }

		[Column("HEADASSESSMENTFORCHIEF")]
		public virtual string? HeadAssessmentForChief { get; set; }

		[Column("ISMECHANIZE")]
		public virtual Anu.Enumerations.YesNo? IsMechanize { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PERSONTYPE")]
		public virtual Anu.Enumerations.PersonType? PersonType { get; set; }

		[Column("PLANNEDOBJECTION")]
		public virtual Anu.Enumerations.PlannedObjection? PlannedObjection { get; set; }

		[Column("PROVINCERESPONSE")]
		public virtual string? ProvinceResponse { get; set; }

		[Column("RELATEDJUDGEDATE")]
		public virtual string? RelatedJudgeDate { get; set; }

		[Column("RELATEDJUDGENO")]
		public virtual string? RelatedJudgeNo { get; set; }

		[Column("REQUESTREASON")]
		public virtual string? RequestReason { get; set; }

		[Column("REQUESTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.Article23RequestType? RequestType { get; set; }

		[Column("SIDENOTE")]
		public virtual string? SideNote { get; set; }

		[ForeignKey("CONDEMNEDPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? TheCondemnedPerson { get; set; }

		[ForeignKey("CONSULTANTEXPERTID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheConsultantExpert { get; set; }

		[ForeignKey("JUDGEEXPERTID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheJudgeExpert { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePArticle23ActionRequest")]
		public virtual List<Anu.PunishmentOrg.Letter.PArticle23ActionReqAttach>? ThePArticle23ActionReqAttachList { get; set; }

		[InverseProperty("ThePArticle23ActionRequest")]
		public virtual List<Anu.PunishmentOrg.Letter.PArticle23ActionRequestUnit>? ThePArticle23ActionRequestUnitList { get; set; }

		[InverseProperty("ThePArticle23ActionRequest")]
		public virtual List<Anu.PunishmentOrg.Letter.PArticle23Assessment>? ThePArticle23AssessmentList { get; set; }

		[ForeignKey("RELATEDCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? TheRelatedCase { get; set; }

		[ForeignKey("RELATEDJUDGEID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? TheRelatedJudge { get; set; }

		[ForeignKey("RELATEDJUDGEUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheRelatedJudgeUnit { get; set; }

		[ForeignKey("REQUESTRECIPIENTUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheRequestRecipientUnit { get; set; }

		[ForeignKey("SUPERIORCOURTID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheSuperiorCourt { get; set; }

		[Column("UNITTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.Article23UnitType? UnitType { get; set; }

    }
    [Table("PARTICLE23ACTIONREQUEST")]
    public partial class PArticle23ActionRequest : PArticle23ActionRequestBase { }

    }


