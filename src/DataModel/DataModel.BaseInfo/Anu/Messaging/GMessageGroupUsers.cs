

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Messaging
{
    public abstract class GMessageGroupUsersBase : BaseInfoEntity<string>
    {

		[ForeignKey("CLIENTUNITID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheClientUnit { get; set; }

		[ForeignKey("CLIENTUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheClientUser { get; set; }

		[ForeignKey("GMESSAGEGROUPID")]
		public virtual Anu.Messaging.GMessageGroup? TheGMessageGroup { get; set; }

    }
    [Table("GMESSAGEGROUPUSERS")]
    public partial class GMessageGroupUsers : GMessageGroupUsersBase { }

    }


