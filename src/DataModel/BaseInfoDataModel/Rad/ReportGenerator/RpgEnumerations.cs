

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgEnumerationsBase : BaseInfoEntity<string>
    {

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheRpgEnumerations")]
		public virtual List<Rad.ReportGenerator.RpgEnumerationAttributes>? TheRpgEnumerationAttributesList { get; set; }

    }
    [Table("RPGENUMERATIONS")]
    public partial class RpgEnumerations : RpgEnumerationsBase { }

    }


