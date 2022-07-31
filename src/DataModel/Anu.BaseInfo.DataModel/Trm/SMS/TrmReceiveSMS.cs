

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Trm.SMS
{
    public abstract class TrmReceiveSMSBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("RECEIVETELNUMBER")]
        public virtual string? ReceiveTelNumber { get; set; }

        [Unicode(false)]
        [Column("SENDERMOBILENUMBER")]
        public virtual string? SenderMobileNumber { get; set; }

        [Unicode(false)]
        [Column("SMSID")]
        public virtual string? SMSID { get; set; }

        [Unicode(false)]
        [Column("SMSTEXT")]
        public virtual string? SMSText { get; set; }

        [InverseProperty("TheTrmReceiveSMS")]
        public virtual List<Anu.BaseInfo.DataModel.Trm.SMS.TrmReceiveSMSNotRespond>? TheTrmReceiveSMSNotRespondList { get; set; }

    }

    [Table("TRMRECEIVESMS")]
    public partial class TrmReceiveSMS : TrmReceiveSMSBase
    {
    }
    }