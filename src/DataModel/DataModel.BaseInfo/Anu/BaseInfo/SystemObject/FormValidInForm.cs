

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemObject
{
    public abstract class FormValidInFormBase : BaseInfoEntity<string>
    {

		[Column("ENGLISHFIELDNAME")]
		public virtual string? EnglishFieldName { get; set; }

		[Column("FARSIFIELDNAME")]
		public virtual string? FarsiFieldName { get; set; }

		[ForeignKey("MAINFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheMainForm { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

    }
    [Table("FORMVALIDINFORM")]
    public partial class FormValidInForm : FormValidInFormBase { }

    }


