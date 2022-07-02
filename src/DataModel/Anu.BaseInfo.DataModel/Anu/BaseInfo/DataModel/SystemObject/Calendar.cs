

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class CalendarBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("CALENDARID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.CalendarDay>? TheCalendarDayList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("CALENDAR")]
    public partial class Calendar : CalendarBase
    {
    }
}