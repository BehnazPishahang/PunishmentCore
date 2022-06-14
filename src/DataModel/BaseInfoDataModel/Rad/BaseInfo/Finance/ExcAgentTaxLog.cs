

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class ExcAgentTaxLogBase : BaseInfoEntity<string>
    {

		[Column("ERRORMESSAGE")]
		public virtual string? ErrorMessage { get; set; }

		[Column("EVENTDATETIME")]
		public virtual string? EventDateTime { get; set; }

		[Column("EVENTTYPE")]
		public virtual decimal? EventType { get; set; }

		[Column("RECEIVEPACKET")]
		public virtual string? ReceivePacket { get; set; }

		[Column("SENDPACKET")]
		public virtual string? SendPacket { get; set; }

		[ForeignKey("EXCAGENTTAXID")]
		public virtual Rad.BaseInfo.Finance.ExcAgentTax? TheExcAgentTax { get; set; }

    }
    [Table("EXCAGENTTAXLOG")]
    public partial class ExcAgentTaxLog : ExcAgentTaxLogBase { }

    }


