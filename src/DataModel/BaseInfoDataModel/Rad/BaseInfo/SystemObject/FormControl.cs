

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class FormControlBase : BaseInfoEntity<string>
    {

		[Column("FNAME")]
		public virtual string? FName { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("PARENTCONTROLID")]
		public virtual List<Rad.BaseInfo.SystemObject.FormControl>? TheChildControlList { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("FORMCONTROL")]
    public partial class FormControl : FormControlBase { }

    }


