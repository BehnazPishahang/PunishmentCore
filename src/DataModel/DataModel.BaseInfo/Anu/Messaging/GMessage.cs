

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Messaging
{
    public abstract class GMessageBase : BaseInfoEntity<string>
    {

		[Column("IP")]
		public virtual string? IP { get; set; }

		[Column("MESSAGEDATETIME")]
		public virtual string? MessageDateTime { get; set; }

		[Column("MESSAGENO")]
		public virtual string? MessageNo { get; set; }

		[Column("MESSAGETEXT")]
		public virtual string? MessageText { get; set; }

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseID { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("RELATEDCASETITLE")]
		public virtual string? RelatedCaseTitle { get; set; }

		[Column("SECURITYTYPE")]
		public virtual Anu.Enumerations.MessageSecurityType? SecurityType { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.MessageState? State { get; set; }

		[InverseProperty("TheGMessage")]
		public virtual List<Anu.Messaging.GMessageReciever>? TheGMessageRecieverList { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("SENDERUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheSenderUser { get; set; }

		[Column("URGENTTYPE")]
		public virtual Anu.Enumerations.MessageForceType? UrgentType { get; set; }

    }
    [Table("GMESSAGE")]
    public partial class GMessage : GMessageBase { }

    }


