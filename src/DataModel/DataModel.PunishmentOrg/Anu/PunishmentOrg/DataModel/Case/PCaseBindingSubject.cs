

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseBindingSubjectBase : PunishmentOrgEntity<string>
    {

        [Column("ENDPENALTYDATE")]
        public virtual string? EndPenaltyDate { get; set; }

        [Column("EXECUTIVESTATUS")]
        public virtual Anu.PunishmentOrg.Enumerations.PUExecutiveStatus? ExecutiveStatus { get; set; }

        [Column("JUDGEDATE")]
        public virtual string? JudgeDate { get; set; }

        [Column("JUDGENO")]
        public virtual string? JudgeNo { get; set; }

        [Column("PENALTYAMOUNT")]
        public virtual decimal? PenaltyAmount { get; set; }

        [Column("PENALTYGETTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PenaltyGetType? PenaltyGetType { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("STARTPENALTYDATE")]
        public virtual string? StartPenaltyDate { get; set; }

        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("ISSUERJUDGEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheIssuerJudgeUnit { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBBINDINGSUBJECTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBindingSubjectType? ThePBBindingSubjectType { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PBill4PaidReason>? ThePBill4PaidReasonList { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubjectProduct>? ThePCaseBindingSubjectProductList { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubjectPrsn>? ThePCaseBindingSubjectPrsnList { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubjectTriple>? ThePCaseBindingSubjectTripleList { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCashReason>? ThePCashReasonList { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionWritBindingSbjt>? ThePExecutionWritBindingSbjtList { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PInstallmentBindingSubject>? ThePInstallmentBindingSubjectList { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubjectRpl>? ThePJudgmentBindingSubjectRplList { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PPaidReason>? ThePPaidReasonList { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPrisonerBindingSubject>? ThePPrisonerBindingSubjectList { get; set; }

        [InverseProperty("ThePCaseBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPublicWorksExecBindingSubj>? ThePPublicWorksExecBindingSubjList { get; set; }

        [ForeignKey("TERMINATETERMINATEORDERID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrder? TheTerminateTerminateOrder { get; set; }

    }

    [Table("PCASEBINDINGSUBJECT")]
    public partial class PCaseBindingSubject : PCaseBindingSubjectBase
    {
    }
}