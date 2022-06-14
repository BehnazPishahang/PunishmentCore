

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class MerchantReportBase : BaseInfoEntity<string>
    {

		[Column("ADDDATA")]
		public virtual string? AddData { get; set; }

		[Column("CARDNO")]
		public virtual string? CardNo { get; set; }

		[Column("COSTTYPEID")]
		public virtual string? CostTypeId { get; set; }

		[Column("CYCLE")]
		public virtual string? Cycle { get; set; }

		[Column("FACTORNO")]
		public virtual string? FactorNo { get; set; }

		[Column("ISPROCESSED")]
		public virtual Rad.CMS.Enumerations.YesNo? IsProcessed { get; set; }

		[Column("MERCHANT")]
		public virtual string? Merchant { get; set; }

		[Column("PAYMENTCODE")]
		public virtual string? PaymentCode { get; set; }

		[Column("PAYMENTTYPE")]
		public virtual string? PaymentType { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[Column("RECIEPTCODE")]
		public virtual string? RecieptCode { get; set; }

		[Column("REPORTDATETIME")]
		public virtual string? ReportDateTime { get; set; }

		[Column("REPORTER")]
		public virtual string? Reporter { get; set; }

		[Column("RRN")]
		public virtual string? RRN { get; set; }

		[Column("SENTTOREVERSE")]
		public virtual string? SentToReverse { get; set; }

		[Column("SENTTOSETTLE")]
		public virtual string? SentToSettle { get; set; }

		[Column("SERVICE")]
		public virtual string? Service { get; set; }

		[Column("SETTLEMENTDATETIME")]
		public virtual string? SettlementDateTime { get; set; }

		[Column("SETTLESUCCESSFUL")]
		public virtual string? SettleSuccessful { get; set; }

		[Column("SHEBA")]
		public virtual string? Sheba { get; set; }

		[Column("SWITCHRESPONSE")]
		public virtual string? SwitchResponse { get; set; }

		[Column("TERMINAL")]
		public virtual string? Terminal { get; set; }

		[Column("TRANSACTIONBASE")]
		public virtual string? TransactionBase { get; set; }

		[Column("TRANSACTIONCODE")]
		public virtual string? TransactionCode { get; set; }

		[Column("TRANSACTIONDATETIME")]
		public virtual string? TransactionDateTime { get; set; }

		[Column("TRANSACTIONRETURNDATETIME")]
		public virtual string? TransactionReturnDateTime { get; set; }

		[Column("TRANSACTIONSERIALNO")]
		public virtual string? TransactionSerialNo { get; set; }

		[Column("TRANSUCCESSFUL")]
		public virtual string? TranSuccessful { get; set; }

    }
    [Table("MERCHANTREPORT")]
    public partial class MerchantReport : MerchantReportBase { }

    }


