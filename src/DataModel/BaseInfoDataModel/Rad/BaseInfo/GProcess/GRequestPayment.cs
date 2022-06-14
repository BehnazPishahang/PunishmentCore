

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestPaymentBase : BaseInfoEntity<string>
    {

		[Column("PAYMENTBANKBRANCH")]
		public virtual string? PaymentBankBranch { get; set; }

		[Column("PAYMENTPHISHDATE")]
		public virtual string? PaymentPhishDate { get; set; }

		[Column("PAYMENTPHISHNO")]
		public virtual string? PaymentPhishNo { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[ForeignKey("GPROCESSSTEPBANKACCOUNTID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStepBankAccount? TheGProcessStepBankAccount { get; set; }

		[ForeignKey("GREQUESTID")]
		public virtual Rad.BaseInfo.GProcess.GRequest? TheGRequest { get; set; }

		[Column("TRANSACTIONSERIALNO")]
		public virtual string? TransactionSerialNo { get; set; }

		[Column("TRANSACTIONTIME")]
		public virtual string? TransactionTime { get; set; }

		[Column("TRANSACTIONTRACKINGCODE")]
		public virtual string? TransactionTrackingCode { get; set; }

		[Column("TRANSATIONREFERENCENO")]
		public virtual string? TransationReferenceNo { get; set; }

    }
    [Table("GREQUESTPAYMENT")]
    public partial class GRequestPayment : GRequestPaymentBase { }

    }


