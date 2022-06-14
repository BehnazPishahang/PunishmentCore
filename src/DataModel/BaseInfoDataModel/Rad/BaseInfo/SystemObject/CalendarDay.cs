

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class CalendarDayBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATE")]
		public virtual string? CreateDate { get; set; }

		[Column("DAYCOUNTER")]
		public virtual decimal? DayCounter { get; set; }

		[Column("DAYKIND")]
		public virtual Rad.CMS.Enumerations.HolidayKind? DayKind { get; set; }

		[Column("WEEKDAY")]
		public virtual Rad.CMS.Enumerations.WeekDay? WeekDay { get; set; }

    }
    [Table("CALENDARDAY")]
    public partial class CalendarDay : CalendarDayBase { }

    }


