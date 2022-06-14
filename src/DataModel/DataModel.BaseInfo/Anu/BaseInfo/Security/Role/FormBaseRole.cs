

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.Security.Role
{
    public abstract class FormBaseRoleBase : BaseInfoEntity<string>
    {

		[ForeignKey("BASEROLEID")]
		public virtual Anu.BaseInfo.Security.Role.BaseRole? TheBaseRole { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("FORMBASEROLE")]
    public partial class FormBaseRole : FormBaseRoleBase { }

    }


