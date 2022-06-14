

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class GWebServiceCallLogParamBase : BaseInfoEntity<string>
    {

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("PARAMBLOBVALUE")]
		public virtual byte[]? ParamBLOBValue { get; set; }

		[Column("PARAMCLOBVALUE")]
		public virtual string? ParamCLOBValue { get; set; }

		[Column("PARAMVALUE")]
		public virtual string? ParamValue { get; set; }

		[ForeignKey("GWEBSERVICECALLLOGID")]
		public virtual Rad.DBLoging.GWebServiceCallLog? TheGWebServiceCallLog { get; set; }

    }
    [Table("GWEBSERVICECALLLOGPARAM")]
    public partial class GWebServiceCallLogParam : GWebServiceCallLogParamBase { }

    }


