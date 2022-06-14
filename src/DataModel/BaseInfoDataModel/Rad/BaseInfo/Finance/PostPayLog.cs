

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class PostPayLogBase : BaseInfoEntity<string>
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

		[ForeignKey("POSTPAYID")]
		public virtual Rad.BaseInfo.Finance.PostPay? ThePostPay { get; set; }

    }
    [Table("POSTPAYLOG")]
    public partial class PostPayLog : PostPayLogBase { }

    }


