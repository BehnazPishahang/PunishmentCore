

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Messaging
{
    public abstract class GMessageRecieverBase : BaseInfoEntity<string>
    {

		[Column("RECIEVERTYPE")]
		public virtual Rad.CMS.Enumerations.MessageRecieverType? RecieverType { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GMESSAGEID")]
		public virtual Rad.Messaging.GMessage? TheGMessage { get; set; }

		[ForeignKey("RECIEVERUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheRecieverUser { get; set; }

		[ForeignKey("VIEWERUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheViewerUser { get; set; }

		[Column("VIEWBYRECIEVER")]
		public virtual Rad.CMS.Enumerations.YesNo? ViewByReciever { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

    }
    [Table("GMESSAGERECIEVER")]
    public partial class GMessageReciever : GMessageRecieverBase { }

    }


