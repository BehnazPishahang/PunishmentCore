

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgEnumerationAttributesBase : BaseInfoEntity<string>
    {

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("EQUALNUMBER")]
		public virtual decimal? EqualNumber { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("RPGENUMERATIONSID")]
		public virtual Rad.ReportGenerator.RpgEnumerations? TheRpgEnumerations { get; set; }

    }
    [Table("RPGENUMERATIONATTRIBUTES")]
    public partial class RpgEnumerationAttributes : RpgEnumerationAttributesBase { }

    }


