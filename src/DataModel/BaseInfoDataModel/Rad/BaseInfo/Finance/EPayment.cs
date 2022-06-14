

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class EPaymentBase : BaseInfoEntity<string>
    {

		[Column("BANKCOUNTERINFO")]
		public virtual string? BankCounterInfo { get; set; }

		[Column("CARDNO")]
		public virtual string? CardNo { get; set; }

		[Column("CMSORGANIZATIONID")]
		public virtual string? CMSOrganizationId { get; set; }

		[Column("CMSUSERID")]
		public virtual string? CMSUserId { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("EXTRADATA")]
		public virtual string? ExtraData { get; set; }

		[Column("HOWTOPAY")]
		public virtual Rad.CMS.Enumerations.HowToPay? HowToPay { get; set; }

		[Column("HOWTOQUOTATION")]
		public virtual string? HowToQuotation { get; set; }

		[Column("HOWTOQUOTATIONWITHVERHOEFF")]
		public virtual string? HowToQuotationWithVerhoeff { get; set; }

		[Column("INVOICENO")]
		public virtual string? InvoiceNo { get; set; }

		[Column("ISPROCESSED")]
		public virtual Rad.CMS.Enumerations.YesNo? IsProcessed { get; set; }

		[Column("NATIONALNO")]
		public virtual string? NationalNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PAYMENTDATETIME")]
		public virtual string? PaymentDateTime { get; set; }

		[Column("PAYMENTNO")]
		public virtual string? PaymentNo { get; set; }

		[Column("PAYMENTOTHERINFORMATION")]
		public virtual string? PaymentOtherInformation { get; set; }

		[Column("PAYMENTTYPE")]
		public virtual string? PaymentType { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[Column("REFID")]
		public virtual string? RefId { get; set; }

		[Column("REFUNDDESCRIPTION")]
		public virtual string? RefundDescription { get; set; }

		[Column("REFUNDID")]
		public virtual string? RefundId { get; set; }

		[Column("REFUNDPRICE")]
		public virtual decimal? RefundPrice { get; set; }

		[Column("REFUNDPRICEHAGHOSABTCADASTRE")]
		public virtual decimal? RefundPriceHaghOSabtCadastre { get; set; }

		[Column("REFUNDPRICEHAGHOSABTHALFPRCNT")]
		public virtual decimal? RefundPriceHaghOSabtHalfPrcnt { get; set; }

		[Column("REFUNDSTATE")]
		public virtual Rad.CMS.Enumerations.PaymentRefundState? RefundState { get; set; }

		[Column("RETURNURL")]
		public virtual string? ReturnURL { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.EPaymentState? State { get; set; }

		[Column("SYSTEMFORMID")]
		public virtual string? SystemFormId { get; set; }

		[Column("SYSTEMNAME")]
		public virtual string? SystemName { get; set; }

		[InverseProperty("TheEPayment")]
		public virtual List<Rad.BaseInfo.Finance.EPaymentEventLog>? TheEPaymentEventLogList { get; set; }

		[InverseProperty("TheEPayment")]
		public virtual List<Rad.BaseInfo.Finance.EPaymentQuotation>? TheEPaymentQuotationList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("EPAYMENT")]
    public partial class EPayment : EPaymentBase { }

    }


