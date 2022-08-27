using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PBill4PaidBase : PunishmentOrgEntity<string>
    {

        [Column("BILLTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.Bill4PaidType? Billtype { get; set; }

        [Unicode(false)]
        [Column("CARDNO")]
        public virtual string? CardNo { get; set; }

        [Unicode(false)]
        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [Unicode(false)]
        [Column("CHECKFICHENO")]
        public virtual string? CheckFicheNo { get; set; }

        [Column("CLOSECASEORNO")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? CloseCaseOrNo { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("FISHNO")]
        public virtual string? FishNo { get; set; }

        [Unicode(false)]
        [Column("RECEIVERNO")]
        public virtual string? ReceiverNo { get; set; }

        [Unicode(false)]
        [Column("SIDENOTE")]
        public virtual string? SideNote { get; set; }

        [Unicode(false)]
        [Column("TERMINALID")]
        public virtual string? TerminalID { get; set; }

        [ForeignKey("ACCOUNTSID")]
        public virtual Anu.BaseInfo.DataModel.Types.Accounts? TheAccounts { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePBill4Paid")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PBill4PaidCase>? ThePBill4PaidCaseList { get; set; }

        [InverseProperty("ThePBill4Paid")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PBill4PaidReason>? ThePBill4PaidReasonList { get; set; }

        [InverseProperty("ThePBill4Paid")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PBill4PaidUnit>? ThePBill4PaidUnitList { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [InverseProperty("ThePBill4Paid")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCash>? ThePCashList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("TOTALPAIDCOST")]
        public virtual long? TotalPaidCost { get; set; }

        [Unicode(false)]
        [Column("TRANSACTIONDATETIMESECOND")]
        public virtual string? TransactionDateTimeSecond { get; set; }

        [Unicode(false)]
        [Column("TRANSACTIONRECEIPT")]
        public virtual string? TransactionReceipt { get; set; }

        }

    [Table("PBILL4PAID")]
    public partial class PBill4Paid : PBill4PaidBase
    {
    }
    }