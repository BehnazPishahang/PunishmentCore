

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentBase : PunishmentOrgEntity<string>
    {

		[Column("CASESNOSUBNO")]
		public virtual string? CasesNoSubno { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("JUDGEDATETIME")]
		public virtual string? JudgeDateTime { get; set; }

		[Column("JUDGETYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUJudgeType? JudgeType { get; set; }

		[Column("JUDGEWRITEDATE")]
		public virtual string? JudgeWriteDate { get; set; }

		[Column("MANUALNO")]
		public virtual string? ManualNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("STATISTICSTATUS")]
		public virtual Anu.Enumerations.PunishmentOrg.PUStatisticStatus? StatisticStatus { get; set; }

		[ForeignKey("ISSUERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheIssuerUnit { get; set; }

		[ForeignKey("MAINJUDGEID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? TheMainJudge { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PBJUDGEMENTTEMPLATETYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBJudgementTemplateType? ThePBJudgementTemplateType { get; set; }

		[InverseProperty("ThePJudgment")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentBindingSubject>? ThePJudgmentBindingSubjectList { get; set; }

		[InverseProperty("ThePJudgment")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentBindingSubjectRpl>? ThePJudgmentBindingSubjectRplList { get; set; }

		[InverseProperty("ThePJudgment")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentCase>? ThePJudgmentCaseList { get; set; }

		[InverseProperty("ThePJudgment")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentIssuer>? ThePJudgmentIssuerList { get; set; }

		[InverseProperty("ThePJudgment")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentTriple>? ThePJudgmentTripleList { get; set; }

		[InverseProperty("ThePJudgment")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentUnit>? ThePJudgmentUnitList { get; set; }

		[InverseProperty("ThePJudgment")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentViolator>? ThePJudgmentViolatorList { get; set; }

		[InverseProperty("ThePJudgment")]
		public virtual List<Anu.PunishmentOrg.Letter.PRevisionRequest>? ThePRevisionRequestList { get; set; }

		[ForeignKey("PRIMITIVEJUDGEID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePrimitiveJudge { get; set; }

		[InverseProperty("ThePrimitiveJudge")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgment>? TheSecondaryJudgeList { get; set; }

		[Column("VERDICTABSTRACT")]
		public virtual string? VerdictAbstract { get; set; }

		[Column("VERDICTTEXT")]
		public virtual string? VerdictText { get; set; }

    }
    [Table("PJUDGMENT")]
    public partial class PJudgment : PJudgmentBase { }

    }


