

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Messaging
{
    public abstract class GMessageGroupBase : BaseInfoEntity<string>
    {

		[Column("GROUPTITLE")]
		public virtual string? GroupTitle { get; set; }

		[InverseProperty("TheGMessageGroup")]
		public virtual List<Anu.Messaging.GMessageGroupUsers>? TheGMessageGroupUsersList { get; set; }

		[ForeignKey("OWNERUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheOwnerUser { get; set; }

    }
    [Table("GMESSAGEGROUP")]
    public partial class GMessageGroup : GMessageGroupBase { }

    }


