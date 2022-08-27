using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Messaging
{
    public abstract class GMessageRecieverBase : BaseInfoEntity<string>
    {

        [Column("RECIEVERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MessageRecieverType? RecieverType { get; set; }

        [ForeignKey("CMSORGANIZATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

        [ForeignKey("GMESSAGEID")]
        public virtual Anu.BaseInfo.DataModel.Messaging.GMessage? TheGMessage { get; set; }

        [ForeignKey("RECIEVERUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheRecieverUser { get; set; }

        [ForeignKey("VIEWERUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheViewerUser { get; set; }

        [Column("VIEWBYRECIEVER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ViewByReciever { get; set; }

        [Unicode(false)]
        [Column("VIEWDATETIME")]
        public virtual string? ViewDateTime { get; set; }

        }

    [Table("GMESSAGERECIEVER")]
    public partial class GMessageReciever : GMessageRecieverBase
    {
    }
    }