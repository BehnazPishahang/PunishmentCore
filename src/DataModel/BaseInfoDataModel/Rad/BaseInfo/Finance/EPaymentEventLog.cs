

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class EPaymentEventLogBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("EVENTDATETIME")]
		public virtual string? EventDateTime { get; set; }

		[Column("EVENTTYPE")]
		public virtual string? EventType { get; set; }

		[Column("HOWTOQUOTATION")]
		public virtual string? HowToQuotation { get; set; }

		[Column("NATIONALNO")]
		public virtual string? NationalNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PAYMENTTYPE")]
		public virtual string? PaymentType { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[ForeignKey("EPAYMENTID")]
		public virtual Rad.BaseInfo.Finance.EPayment? TheEPayment { get; set; }

    }
    [Table("EPAYMENTEVENTLOG")]
    public partial class EPaymentEventLog : EPaymentEventLogBase { }

    }


