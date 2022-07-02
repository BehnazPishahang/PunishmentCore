

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Terminate
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
        public virtual Anu.PunishmentOrg.Enumerations.PUJudgeType? JudgeType { get; set; }

        [Column("JUDGEWRITEDATE")]
        public virtual string? JudgeWriteDate { get; set; }

        [Column("MANUALNO")]
        public virtual string? ManualNo { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("STATISTICSTATUS")]
        public virtual Anu.PunishmentOrg.Enumerations.PUStatisticStatus? StatisticStatus { get; set; }

        [ForeignKey("ISSUERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheIssuerUnit { get; set; }

        [ForeignKey("MAINJUDGEID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? TheMainJudge { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBJUDGEMENTTEMPLATETYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBJudgementTemplateType? ThePBJudgementTemplateType { get; set; }

        [InverseProperty("ThePJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubject>? ThePJudgmentBindingSubjectList { get; set; }

        [InverseProperty("ThePJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubjectRpl>? ThePJudgmentBindingSubjectRplList { get; set; }

        [InverseProperty("ThePJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentCase>? ThePJudgmentCaseList { get; set; }

        [InverseProperty("ThePJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentIssuer>? ThePJudgmentIssuerList { get; set; }

        [InverseProperty("ThePJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentTriple>? ThePJudgmentTripleList { get; set; }

        [InverseProperty("ThePJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentUnit>? ThePJudgmentUnitList { get; set; }

        [InverseProperty("ThePJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentViolator>? ThePJudgmentViolatorList { get; set; }

        [InverseProperty("ThePJudgment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PRevisionRequest>? ThePRevisionRequestList { get; set; }

        [ForeignKey("PRIMITIVEJUDGEID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePrimitiveJudge { get; set; }

        [InverseProperty("ThePrimitiveJudge")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgment>? TheSecondaryJudgeList { get; set; }

        [Column("VERDICTABSTRACT")]
        public virtual string? VerdictAbstract { get; set; }

        [Column("VERDICTTEXT")]
        public virtual string? VerdictText { get; set; }

    }

    [Table("PJUDGMENT")]
    public partial class PJudgment : PJudgmentBase
    {
    }
}