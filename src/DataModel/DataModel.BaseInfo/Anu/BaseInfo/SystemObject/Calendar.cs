

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemObject
{
    public abstract class CalendarBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("CALENDARID")]
		public virtual List<Anu.BaseInfo.SystemObject.CalendarDay>? TheCalendarDayList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("CALENDAR")]
    public partial class Calendar : CalendarBase { }

    }


