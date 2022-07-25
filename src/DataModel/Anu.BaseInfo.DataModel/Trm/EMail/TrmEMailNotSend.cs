

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Trm.EMail
{
    public abstract class TrmEMailNotSendBase : BaseInfoEntity<string>
    {

        [Column("DISPATCHDATETIME")]
        public virtual string? DispatchDateTime { get; set; }

    }

    [Table("TRMEMAILNOTSEND")]
    public partial class TrmEMailNotSend : TrmEMailNotSendBase
    {
    }
}