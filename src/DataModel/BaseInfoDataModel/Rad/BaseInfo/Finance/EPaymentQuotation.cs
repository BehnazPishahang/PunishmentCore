

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class EPaymentQuotationBase : BaseInfoEntity<string>
    {

		[Column("ACCOUNTNO")]
		public virtual string? AccountNo { get; set; }

		[Column("COSTTYPEID")]
		public virtual string? CostTypeId { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[ForeignKey("EPAYMENTID")]
		public virtual Rad.BaseInfo.Finance.EPayment? TheEPayment { get; set; }

    }
    [Table("EPAYMENTQUOTATION")]
    public partial class EPaymentQuotation : EPaymentQuotationBase { }

    }


