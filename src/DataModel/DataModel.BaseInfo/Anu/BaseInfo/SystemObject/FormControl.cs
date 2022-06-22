

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemObject
{
    public abstract class FormControlBase : BaseInfoEntity<string>
    {

		[Column("FNAME")]
		public virtual string? FName { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("PARENTCONTROLID")]
		public virtual List<Anu.BaseInfo.SystemObject.FormControl>? TheChildControlList { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("FORMCONTROL")]
    public partial class FormControl : FormControlBase { }

    }


