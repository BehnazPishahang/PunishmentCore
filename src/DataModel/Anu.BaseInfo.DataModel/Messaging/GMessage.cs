

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Messaging
{
    public abstract class GMessageBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("IP")]
        public virtual string? IP { get; set; }

        [Unicode(false)]
        [Column("MESSAGEDATETIME")]
        public virtual string? MessageDateTime { get; set; }

        [Unicode(false)]
        [Column("MESSAGENO")]
        public virtual string? MessageNo { get; set; }

        [Unicode(false)]
        [Column("MESSAGETEXT")]
        public virtual string? MessageText { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseID { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASENO")]
        public virtual string? RelatedCaseNo { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASETITLE")]
        public virtual string? RelatedCaseTitle { get; set; }

        [Column("SECURITYTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MessageSecurityType? SecurityType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.MessageState? State { get; set; }

        [InverseProperty("TheGMessage")]
        public virtual List<Anu.BaseInfo.DataModel.Messaging.GMessageReciever>? TheGMessageRecieverList { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("SENDERUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheSenderUser { get; set; }

        [Column("URGENTTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MessageForceType? UrgentType { get; set; }

    }

    [Table("GMESSAGE")]
    public partial class GMessage : GMessageBase
    {
    }
    }