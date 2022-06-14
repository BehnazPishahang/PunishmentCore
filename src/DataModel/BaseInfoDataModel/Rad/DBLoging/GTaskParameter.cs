

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class GTaskParameterBase : BaseInfoEntity<string>
    {

		[Column("PARAMNAME")]
		public virtual string? ParamName { get; set; }

		[Column("PARAMVALUE")]
		public virtual byte[]? ParamValue { get; set; }

		[ForeignKey("GTASKID")]
		public virtual Rad.DBLoging.GTask? TheGTask { get; set; }

    }
    [Table("GTASKPARAMETER")]
    public partial class GTaskParameter : GTaskParameterBase { }

    }


