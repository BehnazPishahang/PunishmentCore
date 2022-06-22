

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseBindingSubjectBase : PunishmentOrgEntity<string>
    {

		[Column("ENDPENALTYDATE")]
		public virtual string? EndPenaltyDate { get; set; }

		[Column("EXECUTIVESTATUS")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUExecutiveStatus? ExecutiveStatus { get; set; }

		[Column("JUDGEDATE")]
		public virtual string? JudgeDate { get; set; }

		[Column("JUDGENO")]
		public virtual string? JudgeNo { get; set; }

		[Column("PENALTYAMOUNT")]
		public virtual decimal? PenaltyAmount { get; set; }

		[Column("PENALTYGETTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PenaltyGetType? PenaltyGetType { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("STARTPENALTYDATE")]
		public virtual string? StartPenaltyDate { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("ISSUERJUDGEUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheIssuerJudgeUnit { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBBINDINGSUBJECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBindingSubjectType? ThePBBindingSubjectType { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Accounting.PBill4PaidReason>? ThePBill4PaidReasonList { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseBindingSubjectProduct>? ThePCaseBindingSubjectProductList { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseBindingSubjectPrsn>? ThePCaseBindingSubjectPrsnList { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseBindingSubjectTriple>? ThePCaseBindingSubjectTripleList { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Accounting.PCashReason>? ThePCashReasonList { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Execution.PExecutionWritBindingSbjt>? ThePExecutionWritBindingSbjtList { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Execution.PInstallmentBindingSubject>? ThePInstallmentBindingSubjectList { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentBindingSubjectRpl>? ThePJudgmentBindingSubjectRplList { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Accounting.PPaidReason>? ThePPaidReasonList { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Execution.PPrisonerBindingSubject>? ThePPrisonerBindingSubjectList { get; set; }

		[InverseProperty("ThePCaseBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Execution.PPublicWorksExecBindingSubj>? ThePPublicWorksExecBindingSubjList { get; set; }

		[ForeignKey("TERMINATETERMINATEORDERID")]
		public virtual Anu.PunishmentOrg.Terminate.PTerminateOrder? TheTerminateTerminateOrder { get; set; }

    }
    [Table("PCASEBINDINGSUBJECT")]
    public partial class PCaseBindingSubject : PCaseBindingSubjectBase { }

    }


