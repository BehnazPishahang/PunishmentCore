

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Trm.EMail
{
    public abstract class TrmEMailNotSendBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("DISPATCHDATETIME")]
        public virtual string? DispatchDateTime { get; set; }

    }

    [Table("TRMEMAILNOTSEND")]
    public partial class TrmEMailNotSend : TrmEMailNotSendBase
    {
    }
    }