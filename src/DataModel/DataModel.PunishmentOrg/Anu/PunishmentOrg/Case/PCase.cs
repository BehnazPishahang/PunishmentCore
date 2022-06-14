

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PCaseBase : PunishmentOrgEntity<string>
    {

		[Column("ARCHIVENO")]
		public virtual string? ArchiveNo { get; set; }

		[Column("BILLNOINWAREHOUSE")]
		public virtual string? BillNoInWarehouse { get; set; }

		[Column("BILLNOINWAREHOUSERN")]
		public virtual string? BillNoInWarehouseRN { get; set; }

		[Column("CASEARCHIVESTATE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUCaseArchiveState? CaseArchiveState { get; set; }

		[Column("CASEPASSWORD")]
		public virtual string? CasePassword { get; set; }

		[Column("CASESENDTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.CaseSendType? CaseSendType { get; set; }

		[Column("CASESTORENO")]
		public virtual string? CaseStoreNo { get; set; }

		[Column("CASETITLE")]
		public virtual string? CaseTitle { get; set; }

		[Column("CASETYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUCaseType? CaseType { get; set; }

		[Column("CREATECASETYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUCreateCaseType? CreateCaseType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CREATEDCASEDOCNO")]
		public virtual string? CreatedCaseDocNo { get; set; }

		[Column("ENDDATETIME")]
		public virtual string? EndDateTime { get; set; }

		[Column("GUILD")]
		public virtual Anu.Enumerations.PunishmentOrg.PUGuild? Guild { get; set; }

		[Column("IMPORTANCEDEGREE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUImportanceDegree? ImportanceDegree { get; set; }

		[Column("MANUALNO")]
		public virtual string? ManualNo { get; set; }

		[Column("MECHANIZEINFO")]
		public virtual string? MechanizeInfo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PETITIONDESCRIPTION")]
		public virtual string? PetitionDescription { get; set; }

		[Column("PETITIONREASONS")]
		public virtual string? PetitionReasons { get; set; }

		[Column("PETITIONSUBJECT")]
		public virtual string? PetitionSubject { get; set; }

		[Column("PREBILLNOINWAREHOUSE")]
		public virtual string? PreBillNoInWarehouse { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[Column("SUBNO")]
		public virtual long? SubNo { get; set; }

		[ForeignKey("CREATORPERSONID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheCreatorPerson { get; set; }

		[ForeignKey("EXECUTIVEPERSONID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheExecutivePerson { get; set; }

		[ForeignKey("HANDLERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheHandlerUnit { get; set; }

		[InverseProperty("TheWrapCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseWrap>? TheMainCasesList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.ArrestSaftyWrit.PArrested>? ThePArrestedList { get; set; }

		[InverseProperty("TheRelatedCase")]
		public virtual List<Anu.PunishmentOrg.Letter.PArticle23ActionRequest>? ThePArticle23ActionRequestList { get; set; }

		[ForeignKey("PBCASESTOREID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBCaseStore? ThePBCaseStore { get; set; }

		[ForeignKey("PBEXCHANGEUNITMASTERID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnitMaster { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Accounting.PBill4PaidCase>? ThePBill4PaidCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.BillStore.PBillStore>? ThePBillStoreList { get; set; }

		[ForeignKey("PBREGULATORYPLANID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBRegulatoryPlan? ThePBRegulatoryPlan { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.ArrestSaftyWrit.PCancelSaftyWrit>? ThePCancelSaftyWritList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseBindingSubject>? ThePCaseBindingSubjectList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseEvent>? ThePCaseEventList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseInput>? ThePCaseInputList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCasePerson>? ThePCasePersonList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseProduct>? ThePCaseProductList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseTriple>? ThePCaseTripleList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseUnit>? ThePCaseUnitList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseVehicle>? ThePCaseVehicleList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseViolation>? ThePCaseViolationList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Accounting.PCashByMobilePOS>? ThePCashByMobilePOSList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Accounting.PCashCase>? ThePCashCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>? ThePDiscoveryMinutesList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PEnumerationWritCase>? ThePEnumerationWritCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PEnumerationWritWrapCase>? ThePEnumerationWritWrapCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Execution.PExecutionRemovalWrit>? ThePExecutionRemovalWritList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Execution.PExecutionWrit>? ThePExecutionWritList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PGravamen>? ThePGravamenList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Letter.PIncomingLetterCase>? ThePIncomingLetterCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.InspectionReport.PInspectionReport>? ThePInspectionReportList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Execution.PInstallment>? ThePInstallmentList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PInterimVisibleCase>? ThePInterimVisibleCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentCase>? ThePJudgmentCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Letter.PMechanizedLetterCase>? ThePMechanizedLetterCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PNote1Article21Protest>? ThePNote1Article21ProtestList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticeAdvertisingCase>? ThePNoticeAdvertisingCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticePerson>? ThePNoticePersonList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Letter.POutgoingLetterCase>? ThePOutgoingLetterCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Letter.POutgoingLetterSendCase>? ThePOutgoingLetterSendCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Accounting.PPaidDoc>? ThePPaidDocList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Execution.PPrisoner>? ThePPrisonerList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PProceedingMinuteCase>? ThePProceedingMinuteCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Execution.PPublicWorksExec>? ThePPublicWorksExecList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PRegistaryTimeCase>? ThePRegistaryTimeCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Letter.PRevisionRequestCase>? ThePRevisionRequestCaseList { get; set; }

		[ForeignKey("PRIMITIVEUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? ThePrimitiveUnit { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWritAccept>? ThePSaftyWritAcceptList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWrit>? ThePSaftyWritList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Execution.PStopExecutiveOrder>? ThePStopExecutiveOrderList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Terminate.PTerminateOrderCase>? ThePTerminateOrderCaseList { get; set; }

		[InverseProperty("ThePCase")]
		public virtual List<Anu.PunishmentOrg.Case.PTransferCaseCases>? ThePTransferCaseCasesList { get; set; }

		[InverseProperty("TheMainCase")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseWrap>? TheWrapCasesList { get; set; }

		[Column("TOTALVIOLATIONPRICE")]
		public virtual long? TotalViolationPrice { get; set; }

		[Column("TOTALVIOLATIONPRICEBYCOURT")]
		public virtual long? TotalViolationPriceByCourt { get; set; }

		[Column("TOTALVIOLATIONPRICEBYEXPERT")]
		public virtual long? TotalViolationPriceByExpert { get; set; }

		[Column("VERIFICATIONDATETIME")]
		public virtual string? VerificationDateTime { get; set; }

		[Column("VERIFICATIONRESULT")]
		public virtual string? VerificationResult { get; set; }

    }
    [Table("PCASE")]
    public partial class PCase : PCaseBase { }

    }


