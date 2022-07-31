

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class OfflineServiceCallNotSendBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("DISPATCHDATETIME")]
        public virtual string? DispatchDateTime { get; set; }

        [Column("RESPITESENDTIME")]
        public virtual long? RespiteSendTime { get; set; }

        [ForeignKey("OFFLINESERVICECALLID")]
        public virtual Anu.BaseInfo.DataModel.DBLoging.OfflineServiceCall? TheOfflineServiceCall { get; set; }

    }

    [Table("OFFLINESERVICECALLNOTSEND")]
    public partial class OfflineServiceCallNotSend : OfflineServiceCallNotSendBase
    {
    }
    }