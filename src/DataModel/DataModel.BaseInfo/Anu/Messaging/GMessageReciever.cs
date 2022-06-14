

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Messaging
{
    public abstract class GMessageRecieverBase : BaseInfoEntity<string>
    {

		[Column("RECIEVERTYPE")]
		public virtual Anu.Enumerations.MessageRecieverType? RecieverType { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GMESSAGEID")]
		public virtual Anu.Messaging.GMessage? TheGMessage { get; set; }

		[ForeignKey("RECIEVERUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheRecieverUser { get; set; }

		[ForeignKey("VIEWERUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheViewerUser { get; set; }

		[Column("VIEWBYRECIEVER")]
		public virtual Anu.Enumerations.YesNo? ViewByReciever { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

    }
    [Table("GMESSAGERECIEVER")]
    public partial class GMessageReciever : GMessageRecieverBase { }

    }


