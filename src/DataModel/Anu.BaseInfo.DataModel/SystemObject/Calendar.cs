

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class CalendarBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("CALENDARID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.CalendarDay>? TheCalendarDayList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("CALENDAR")]
    public partial class Calendar : CalendarBase
    {
    }
    }