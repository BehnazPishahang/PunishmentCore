

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class FormBaseRoleBase : BaseInfoEntity<string>
    {

		[ForeignKey("BASEROLEID")]
		public virtual Rad.BaseInfo.Security.Role.BaseRole? TheBaseRole { get; set; }

		[ForeignKey("SIMPLEBASEROLEID")]
		public virtual Rad.BaseInfo.Security.Role.SimpleBaseRole? TheSimpleBaseRole { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("FORMBASEROLE")]
    public partial class FormBaseRole : FormBaseRoleBase { }

    }


