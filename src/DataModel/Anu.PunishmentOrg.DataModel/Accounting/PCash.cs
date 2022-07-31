

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PCashBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("CARDNO")]
        public virtual string? CardNo { get; set; }

        [Unicode(false)]
        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [Unicode(false)]
        [Column("CHECKFICHEDATE")]
        public virtual string? CheckFicheDate { get; set; }

        [Unicode(false)]
        [Column("CHECKFICHENO")]
        public virtual string? CheckFicheNo { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("PAIDPERSONTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUAccountPersonType? PaidPersonType { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Unicode(false)]
        [Column("RECEIVERNO")]
        public virtual string? ReceiverNo { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

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

        [ForeignKey("PAIDCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePaidCasePerson { get; set; }

        [ForeignKey("PBILL4PAIDID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PBill4Paid? ThePBill4Paid { get; set; }

        [ForeignKey("PCASHBYMOBILEPOSID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PCashByMobilePOS? ThePCashByMobilePOS { get; set; }

        [InverseProperty("ThePCash")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCashCase>? ThePCashCaseList { get; set; }

        [InverseProperty("ThePCash")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCashReason>? ThePCashReasonList { get; set; }

        [InverseProperty("ThePCash")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCashUnit>? ThePCashUnitList { get; set; }

        [InverseProperty("ThePCash")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PPaidRelatedCash>? ThePPaidRelatedCashList { get; set; }

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

    [Table("PCASH")]
    public partial class PCash : PCashBase
    {
    }
    }