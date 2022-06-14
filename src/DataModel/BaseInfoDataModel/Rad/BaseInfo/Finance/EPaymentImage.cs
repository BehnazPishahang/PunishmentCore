

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class EPaymentImageBase : BaseInfoEntity<string>
    {

		[Column("EPAYMENTID")]
		public virtual string? EPaymentId { get; set; }

		[Column("IMAGE")]
		public virtual byte[]? Image { get; set; }

    }
    [Table("EPAYMENTIMAGE")]
    public partial class EPaymentImage : EPaymentImageBase { }

    }


