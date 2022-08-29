using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PCashByMobilePOSBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CARDNO")]
        public virtual string? CardNo { get; set; }

        [Unicode(false)]
        [Column("CHECKFICHENO")]
        public virtual string? CheckFicheNo { get; set; }

        [Unicode(false)]
        [Column("OUTERCASENO")]
        public virtual string? OuterCaseNo { get; set; }

        [Unicode(false)]
        [Column("RECEIVERNO")]
        public virtual string? ReceiverNo { get; set; }

        [Unicode(false)]
        [Column("TERMINALID")]
        public virtual string? TerminalID { get; set; }

        [ForeignKey("ACCOUNTSID")]
        public virtual Anu.BaseInfo.DataModel.Types.Accounts? TheAccounts { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePCashByMobilePOS")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCash>? ThePCashList { get; set; }

        [ForeignKey("PMOBILEPOSREGISTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PMobilePOSRegister? ThePMobilePOSRegister { get; set; }

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

    [Table("PCASHBYMOBILEPOS")]
    public partial class PCashByMobilePOS : PCashByMobilePOSBase
    {
    }
    }