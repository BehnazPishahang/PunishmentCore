

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Trm.SMS
{
    public abstract class TrmSMSNotSendBase : BaseInfoEntity<string>
    {

		[Column("DISPATCHDATETIME")]
		public virtual string? DispatchDateTime { get; set; }

		[Column("RESPITESENDTIME")]
		public virtual long? RespiteSendTime { get; set; }

    }
    [Table("TRMSMSNOTSEND")]
    public partial class TrmSMSNotSend : TrmSMSNotSendBase { }

    }


