

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.CMSUser
{
    public abstract class UserFolderSecurityBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[Column("SECURITYCOUNT")]
		public virtual decimal? SecurityCount { get; set; }

		[ForeignKey("OBJECTTYPEID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheObjectType { get; set; }

		[ForeignKey("USERDEFINEPOSITIONID")]
		public virtual Rad.BaseInfo.Security.Position.UserDefinePosition? TheUserDefinePosition { get; set; }

    }
    [Table("USERFOLDERSECURITY")]
    public partial class UserFolderSecurity : UserFolderSecurityBase { }

    }


