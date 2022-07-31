

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PPOSTestLogBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CARDNO")]
        public virtual string? CardNo { get; set; }

        [Unicode(false)]
        [Column("CHECKFICHENO")]
        public virtual string? CheckFicheNo { get; set; }

        [Unicode(false)]
        [Column("RECEIVERNO")]
        public virtual string? ReceiverNo { get; set; }

        [Unicode(false)]
        [Column("TERMINALID")]
        public virtual string? TerminalID { get; set; }

        [Column("TOTALPAIDCOST")]
        public virtual long? TotalPaidCost { get; set; }

        [Unicode(false)]
        [Column("TRANSACTIONDATETIMESECOND")]
        public virtual string? TransactionDateTimeSecond { get; set; }

        [Unicode(false)]
        [Column("TRANSACTIONRECEIPT")]
        public virtual string? TransactionReceipt { get; set; }

    }

    [Table("PPOSTESTLOG")]
    public partial class PPOSTestLog : PPOSTestLogBase
    {
    }
    }