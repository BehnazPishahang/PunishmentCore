

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Individual
{
    public abstract class RelativeBase : BaseInfoEntity<string>
    {

		[Column("DEGREE")]
		public virtual long? Degree { get; set; }

		[Column("LEVELING")]
		public virtual long? Leveling { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("RELATIVE")]
    public partial class Relative : RelativeBase { }

    }


