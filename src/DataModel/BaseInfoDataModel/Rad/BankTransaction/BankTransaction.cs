

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BankTransaction
{
    public abstract class BankTransactionBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DEPOSITORWITHDRAWAL")]
		public virtual Rad.CMS.Enumerations.DepositOrWithdrawal? DepositOrWithdrawal { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PAYMENTOR")]
		public virtual string? Paymentor { get; set; }

		[ForeignKey("ACCOUNTSID")]
		public virtual Rad.BaseInfo.Finance.Accounts? TheAccounts { get; set; }

		[Column("TRACKNO")]
		public virtual string? TrackNo { get; set; }

		[Column("TRANSACTIONDATETIME")]
		public virtual string? TransactionDateTime { get; set; }

    }
    [Table("BANKTRANSACTION")]
    public partial class BankTransaction : BankTransactionBase { }

    }


