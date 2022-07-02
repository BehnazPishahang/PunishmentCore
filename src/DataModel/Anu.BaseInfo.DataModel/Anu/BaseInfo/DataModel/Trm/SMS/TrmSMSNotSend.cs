

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Trm.SMS
{
    public abstract class TrmSMSNotSendBase : BaseInfoEntity<string>
    {

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