

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemObject
{
    public abstract class CalendarDayBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATE")]
		public virtual string? CreateDate { get; set; }

		[Column("DAYCOUNTER")]
		public virtual long? DayCounter { get; set; }

		[Column("DAYKIND")]
		public virtual Anu.Enumerations.HolidayKind? DayKind { get; set; }

		[Column("WEEKDAY")]
		public virtual Anu.Enumerations.WeekDay? WeekDay { get; set; }

    }
    [Table("CALENDARDAY")]
    public partial class CalendarDay : CalendarDayBase { }

    }


