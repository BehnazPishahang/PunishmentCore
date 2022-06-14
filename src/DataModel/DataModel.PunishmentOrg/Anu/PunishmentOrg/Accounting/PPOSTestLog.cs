

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Accounting
{
    public abstract class PPOSTestLogBase : PunishmentOrgEntity<string>
    {

		[Column("CARDNO")]
		public virtual string? CardNo { get; set; }

		[Column("CHECKFICHENO")]
		public virtual string? CheckFicheNo { get; set; }

		[Column("RECEIVERNO")]
		public virtual string? ReceiverNo { get; set; }

		[Column("TERMINALID")]
		public virtual string? TerminalID { get; set; }

		[Column("TOTALPAIDCOST")]
		public virtual long? TotalPaidCost { get; set; }

		[Column("TRANSACTIONDATETIMESECOND")]
		public virtual string? TransactionDateTimeSecond { get; set; }

		[Column("TRANSACTIONRECEIPT")]
		public virtual string? TransactionReceipt { get; set; }

    }
    [Table("PPOSTESTLOG")]
    public partial class PPOSTestLog : PPOSTestLogBase { }

    }


