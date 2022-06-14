

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DBLoging
{
    public abstract class OfflineServiceCallNotSendBase : BaseInfoEntity<string>
    {

		[Column("DISPATCHDATETIME")]
		public virtual string? DispatchDateTime { get; set; }

		[Column("RESPITESENDTIME")]
		public virtual long? RespiteSendTime { get; set; }

		[ForeignKey("OFFLINESERVICECALLID")]
		public virtual Anu.DBLoging.OfflineServiceCall? TheOfflineServiceCall { get; set; }

    }
    [Table("OFFLINESERVICECALLNOTSEND")]
    public partial class OfflineServiceCallNotSend : OfflineServiceCallNotSendBase { }

    }


