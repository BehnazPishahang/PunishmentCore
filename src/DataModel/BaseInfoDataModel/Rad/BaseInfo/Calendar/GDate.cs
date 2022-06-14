

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Calendar
{
    public abstract class GDateBase : BaseInfoEntity<string>
    {

		[Column("DAYOFMONTH")]
		public virtual decimal? DAYOFMONTH { get; set; }

		[Column("DAYOFWEEK")]
		public virtual string? DAYOFWEEK { get; set; }

		[Column("DAYOFWEEK_NUMBER")]
		public virtual decimal? DAYOFWEEK_NUMBER { get; set; }

		[Column("DAYOFYEAR")]
		public virtual decimal? DAYOFYEAR { get; set; }

		[Column("HOLIDAY")]
		public virtual decimal? HOLIDAY { get; set; }

		[Column("JALALIDATE")]
		public virtual string? JalaliDate { get; set; }

		[Column("MILADIDATE")]
		public virtual string? MILADIDATE { get; set; }

		[Column("SEASON")]
		public virtual string? SEASON { get; set; }

		[Column("TERM")]
		public virtual string? TERM { get; set; }

    }
    [Table("GDATE")]
    public partial class GDate : GDateBase { }

    }


