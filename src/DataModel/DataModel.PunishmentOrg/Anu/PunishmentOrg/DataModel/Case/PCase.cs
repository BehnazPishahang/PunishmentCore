

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
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
        public virtual Anu.PunishmentOrg.Enumerations.PUCaseArchiveState? CaseArchiveState { get; set; }

        [Column("CASEPASSWORD")]
        public virtual string? CasePassword { get; set; }

        [Column("CASESENDTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.CaseSendType? CaseSendType { get; set; }

        [Column("CASESTORENO")]
        public virtual string? CaseStoreNo { get; set; }

        [Column("CASETITLE")]
        public virtual string? CaseTitle { get; set; }

        [Column("CASETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUCaseType? CaseType { get; set; }

        [Column("CREATECASETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUCreateCaseType? CreateCaseType { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("CREATEDCASEDOCNO")]
        public virtual string? CreatedCaseDocNo { get; set; }

        [Column("ENDDATETIME")]
        public virtual string? EndDateTime { get; set; }

        [Column("GUILD")]
        public virtual Anu.PunishmentOrg.Enumerations.PUGuild? Guild { get; set; }

        [Column("IMPORTANCEDEGREE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUImportanceDegree? ImportanceDegree { get; set; }

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
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheCreatorPerson { get; set; }

        [ForeignKey("EXECUTIVEPERSONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheExecutivePerson { get; set; }

        [ForeignKey("HANDLERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheHandlerUnit { get; set; }

        [InverseProperty("TheWrapCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseWrap>? TheMainCasesList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PArrested>? ThePArrestedList { get; set; }

        [InverseProperty("TheRelatedCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PArticle23ActionRequest>? ThePArticle23ActionRequestList { get; set; }

        [ForeignKey("PBCASESTOREID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBCaseStore? ThePBCaseStore { get; set; }

        [ForeignKey("PBEXCHANGEUNITMASTERID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnitMaster { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PBill4PaidCase>? ThePBill4PaidCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.BillStore.PBillStore>? ThePBillStoreList { get; set; }

        [ForeignKey("PBREGULATORYPLANID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBRegulatoryPlan? ThePBRegulatoryPlan { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PCancelSaftyWrit>? ThePCancelSaftyWritList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject>? ThePCaseBindingSubjectList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseEvent>? ThePCaseEventList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseInput>? ThePCaseInputList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCasePerson>? ThePCasePersonList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseProduct>? ThePCaseProductList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseTriple>? ThePCaseTripleList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseUnit>? ThePCaseUnitList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseVehicle>? ThePCaseVehicleList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseViolation>? ThePCaseViolationList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCashByMobilePOS>? ThePCashByMobilePOSList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCashCase>? ThePCashCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes>? ThePDiscoveryMinutesList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWritCase>? ThePEnumerationWritCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWritWrapCase>? ThePEnumerationWritWrapCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionRemovalWrit>? ThePExecutionRemovalWritList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PExecutionWrit>? ThePExecutionWritList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamen>? ThePGravamenList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PIncomingLetterCase>? ThePIncomingLetterCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReport>? ThePInspectionReportList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PInstallment>? ThePInstallmentList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PInterimVisibleCase>? ThePInterimVisibleCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentCase>? ThePJudgmentCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PMechanizedLetterCase>? ThePMechanizedLetterCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PNote1Article21Protest>? ThePNote1Article21ProtestList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticeAdvertisingCase>? ThePNoticeAdvertisingCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticePerson>? ThePNoticePersonList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.POutgoingLetterCase>? ThePOutgoingLetterCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.POutgoingLetterSendCase>? ThePOutgoingLetterSendCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PPaidDoc>? ThePPaidDocList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPrisoner>? ThePPrisonerList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PProceedingMinuteCase>? ThePProceedingMinuteCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPublicWorksExec>? ThePPublicWorksExecList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PRegistaryTimeCase>? ThePRegistaryTimeCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PRevisionRequestCase>? ThePRevisionRequestCaseList { get; set; }

        [ForeignKey("PRIMITIVEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePrimitiveUnit { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWritAccept>? ThePSaftyWritAcceptList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWrit>? ThePSaftyWritList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PStopExecutiveOrder>? ThePStopExecutiveOrderList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrderCase>? ThePTerminateOrderCaseList { get; set; }

        [InverseProperty("ThePCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PTransferCaseCases>? ThePTransferCaseCasesList { get; set; }

        [InverseProperty("TheMainCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseWrap>? TheWrapCasesList { get; set; }

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
    public partial class PCase : PCaseBase
    {
    }
}