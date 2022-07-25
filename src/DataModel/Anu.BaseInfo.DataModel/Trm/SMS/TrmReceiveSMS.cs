

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Trm.SMS
{
    public abstract class TrmReceiveSMSBase : BaseInfoEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("RECEIVETELNUMBER")]
        public virtual string? ReceiveTelNumber { get; set; }

        [Column("SENDERMOBILENUMBER")]
        public virtual string? SenderMobileNumber { get; set; }

        [Column("SMSID")]
        public virtual string? SMSID { get; set; }

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