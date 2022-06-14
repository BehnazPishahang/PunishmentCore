

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Calendar
{
    public abstract class WorkTimeBase : BaseInfoEntity<string>
    {

		[Column("DAYOFWEEK")]
		public virtual Rad.CMS.Enumerations.WeekDay? DayOfWeek { get; set; }

		[Column("FROMHOUR")]
		public virtual decimal? FROMHOUR { get; set; }

		[Column("HOURTO")]
		public virtual decimal? HOURTO { get; set; }

		[Column("SUMOFHOUR")]
		public virtual decimal? SUMOFHOUR { get; set; }

		[ForeignKey("CALENDARCONFID")]
		public virtual Rad.BaseInfo.Calendar.CalendarConf? TheCalendarConf { get; set; }

    }
    [Table("WORKTIME")]
    public partial class WorkTime : WorkTimeBase { }

    }


