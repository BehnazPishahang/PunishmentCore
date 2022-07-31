

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Trm.SMS
{
    public abstract class TrmSMSNotSendBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("DISPATCHDATETIME")]
        public virtual string? DispatchDateTime { get; set; }

        [Column("RESPITESENDTIME")]
        public virtual long? RespiteSendTime { get; set; }

    }

    [Table("TRMSMSNOTSEND")]
    public partial class TrmSMSNotSend : TrmSMSNotSendBase
    {
    }
    }