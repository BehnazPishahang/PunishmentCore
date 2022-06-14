

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class ExcAgentTaxBase : BaseInfoEntity<string>
    {

		[Column("AGENTNAMEFAMILY")]
		public virtual string? AgentNameFamily { get; set; }

		[Column("AGENTPOST")]
		public virtual string? AgentPost { get; set; }

		[Column("ATTORNEYAMOUNT")]
		public virtual decimal? AttorneyAmount { get; set; }

		[Column("BILLACCOUNTNUMBER")]
		public virtual string? BillAccountNumber { get; set; }

		[Column("BILLAMOUNT")]
		public virtual decimal? BillAmount { get; set; }

		[Column("BILLDATE")]
		public virtual string? BillDate { get; set; }

		[Column("BILLID")]
		public virtual string? BillId { get; set; }

		[Column("BILLSHABANUMBER")]
		public virtual string? BillShabaNumber { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("EXECUTEDATE")]
		public virtual string? ExecuteDate { get; set; }

		[Column("EXECUTENO")]
		public virtual string? ExecuteNo { get; set; }

		[Column("LAWYERMELLICODE")]
		public virtual string? LawyerMelliCode { get; set; }

		[Column("LAWYERMOBILENO")]
		public virtual string? LawyerMobileNo { get; set; }

		[Column("PAYMENTDATE")]
		public virtual string? PaymentDate { get; set; }

		[Column("PAYMENTDATETIME")]
		public virtual string? PaymentDateTime { get; set; }

		[Column("RECEIVEPAYMENTID")]
		public virtual string? ReceivePaymentID { get; set; }

		[Column("SSAABILLNO")]
		public virtual string? SSAABillNo { get; set; }

		[Column("SSAAFACTORDATE")]
		public virtual string? SSAAFactorDate { get; set; }

		[Column("SSAAFACTORNO")]
		public virtual string? SSAAFactorNo { get; set; }

		[Column("SSAAHOWTOPAY")]
		public virtual string? SSAAHowToPay { get; set; }

		[Column("SSAAPAYMENTTYPE")]
		public virtual string? SSAAPaymentType { get; set; }

		[Column("SSAARECEIPTNO")]
		public virtual string? SSAAReceiptNo { get; set; }

		[Column("STATUS")]
		public virtual string? Status { get; set; }

		[Column("TAXAMOUNT")]
		public virtual decimal? TaxAmount { get; set; }

		[Column("TRACECODE")]
		public virtual string? TraceCode { get; set; }

		[Column("XIEXECUTIVETYPETITLE")]
		public virtual string? XIExecutiveTypeTitle { get; set; }

    }
    [Table("EXCAGENTTAX")]
    public partial class ExcAgentTax : ExcAgentTaxBase { }

    }


