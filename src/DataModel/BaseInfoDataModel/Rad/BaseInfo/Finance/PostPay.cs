

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class PostPayBase : BaseInfoEntity<string>
    {

		[Column("ACCOUNTNUMBER")]
		public virtual string? AccountNumber { get; set; }

		[Column("BILLNO")]
		public virtual string? BillNo { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DOCDATE")]
		public virtual string? DocDate { get; set; }

		[Column("DOCNO")]
		public virtual string? DocNo { get; set; }

		[Column("DOCTYPETITLE")]
		public virtual string? DocTypeTitle { get; set; }

		[Column("FACTORNO")]
		public virtual string? FactorNo { get; set; }

		[Column("HOWTOPAY")]
		public virtual string? HowToPay { get; set; }

		[Column("PAYMENTDATETIME")]
		public virtual string? PaymentDateTime { get; set; }

		[Column("PAYMENTSTATUS")]
		public virtual Rad.CMS.Enumerations.YesNo? PaymentStatus { get; set; }

		[Column("PAYMENTTYPE")]
		public virtual string? PaymentType { get; set; }

		[Column("POSTBARCODE")]
		public virtual string? PostBarcode { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[Column("RECEIPTNO")]
		public virtual string? ReceiptNo { get; set; }

		[Column("RECIEVERADDRESS")]
		public virtual string? RecieverAddress { get; set; }

		[Column("RECIEVERFAMILY")]
		public virtual string? RecieverFamily { get; set; }

		[Column("RECIEVERMOBILENO")]
		public virtual string? RecieverMobileNo { get; set; }

		[Column("RECIEVERNAME")]
		public virtual string? RecieverName { get; set; }

		[Column("RECIEVERNATIONALNO")]
		public virtual string? RecieverNationalNo { get; set; }

		[Column("RECIEVERPOST")]
		public virtual string? RecieverPost { get; set; }

		[Column("RECIEVERPOSTALCODE")]
		public virtual string? RecieverPostalCode { get; set; }

		[Column("SENDERADDRESS")]
		public virtual string? SenderAddress { get; set; }

		[Column("SENDERFAMILY")]
		public virtual string? SenderFamily { get; set; }

		[Column("SENDERMOBILENO")]
		public virtual string? SenderMobileNo { get; set; }

		[Column("SENDERNAME")]
		public virtual string? SenderName { get; set; }

		[Column("SENDERNATIONALNO")]
		public virtual string? SenderNationalNo { get; set; }

		[Column("SENDERPOST")]
		public virtual string? SenderPost { get; set; }

		[Column("SENDERPOSTALCODE")]
		public virtual string? SenderPostalCode { get; set; }

		[Column("SHABANUMBER")]
		public virtual string? ShabaNumber { get; set; }

		[Column("SUBJECT")]
		public virtual string? Subject { get; set; }

		[Column("SYSTEMNAME")]
		public virtual Rad.CMS.Enumerations.Subsystems? SystemName { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("POSTPAY")]
    public partial class PostPay : PostPayBase { }

    }


