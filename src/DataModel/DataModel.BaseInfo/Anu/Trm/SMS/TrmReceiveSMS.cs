

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Trm.SMS
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
		public virtual List<Anu.Trm.SMS.TrmReceiveSMSNotRespond>? TheTrmReceiveSMSNotRespondList { get; set; }

    }
    [Table("TRMRECEIVESMS")]
    public partial class TrmReceiveSMS : TrmReceiveSMSBase { }

    }


