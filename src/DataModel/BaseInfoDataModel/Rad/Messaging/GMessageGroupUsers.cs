

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Messaging
{
    public abstract class GMessageGroupUsersBase : BaseInfoEntity<string>
    {

		[ForeignKey("CLIENTUNITID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheClientUnit { get; set; }

		[ForeignKey("CLIENTUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheClientUser { get; set; }

		[ForeignKey("GMESSAGEGROUPID")]
		public virtual Rad.Messaging.GMessageGroup? TheGMessageGroup { get; set; }

    }
    [Table("GMESSAGEGROUPUSERS")]
    public partial class GMessageGroupUsers : GMessageGroupUsersBase { }

    }


