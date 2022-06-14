

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class MerchantFeedbackBase : BaseInfoEntity<string>
    {

		[Column("CARDNO")]
		public virtual string? CardNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PAYMENTDATETIME")]
		public virtual string? PaymentDateTime { get; set; }

		[Column("PAYMENTNO")]
		public virtual string? PaymentNo { get; set; }

		[Column("PAYMENTOTHERINFORMATION")]
		public virtual string? PaymentOtherInformation { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[Column("STATE")]
		public virtual string? State { get; set; }

    }
    [Table("MERCHANTFEEDBACK")]
    public partial class MerchantFeedback : MerchantFeedbackBase { }

    }


